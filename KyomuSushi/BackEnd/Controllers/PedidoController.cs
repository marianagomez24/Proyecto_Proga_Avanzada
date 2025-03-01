using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        // GET: api/<PedidoController>
        [HttpGet]
        public IEnumerable<PedidoDTO> Get()
        {
            return _pedidoService.GetPedidos();
        }

        // GET api/<PedidoController>/5
        [HttpGet("{id}")]
        public ActionResult<PedidoDTO> Get(int id)
        {
            var pedido = _pedidoService.GetPedidoById(id);
            if (pedido == null)
            {
                return NotFound();
            }
            return Ok(pedido);
        }

        // POST api/<PedidoController>
        [HttpPost]
        public ActionResult Post([FromBody] PedidoDTO pedido)
        {
            if (pedido == null)
            {
                return BadRequest();
            }
            _pedidoService.Add(pedido);
            return CreatedAtAction(nameof(Get), new { id = pedido.IdPedido }, pedido);
        }

        // PUT api/<PedidoController>/5
        [HttpPut]
        public ActionResult Put([FromBody] PedidoDTO pedido)
        {
            if (pedido == null)
            {
                return BadRequest();
            }
            _pedidoService.Update(pedido);
            return NoContent();
        }

        // DELETE api/<PedidoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existingPedido = _pedidoService.GetPedidoById(id);
            if (existingPedido == null)
            {
                return NotFound();
            }
            _pedidoService.Delete(id);
            return NoContent();
        }
    }
}
