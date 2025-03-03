using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoController : ControllerBase
    {
        private readonly IPagoService _pagoService;

        public PagoController(IPagoService pagoService)
        {
            _pagoService = pagoService;
        }

        // GET: api/<PagoController>
        [HttpGet]
        public IEnumerable<PagoDTO> Get()
        {
            return _pagoService.GetPagos();
        }

        // GET api/<PagoController>/5
        [HttpGet("{id}")]
        public ActionResult<PagoDTO> Get(int id)
        {
            var pago = _pagoService.GetPagoById(id);
            if (pago == null)
            {
                return NotFound();
            }
            return Ok(pago);
        }

        // POST api/<PagoController>
        [HttpPost]
        public ActionResult Post([FromBody] PagoDTO pago)
        {
            if (pago == null)
            {
                return BadRequest();
            }
            _pagoService.Add(pago);
            return CreatedAtAction(nameof(Get), new { id = pago.IdPago }, pago);
        }

        // PUT api/<PagoController>/5
        [HttpPut]
        public ActionResult Put([FromBody] PagoDTO pago)
        {
            if (pago == null)
            {
                return BadRequest();
            }
            _pagoService.Update(pago);
            return NoContent();
        }

        // DELETE api/<PagoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existingPago = _pagoService.GetPagoById(id);
            if (existingPago == null)
            {
                return NotFound();
            }
            _pagoService.Delete(id);
            return NoContent();
        }
    }
}
