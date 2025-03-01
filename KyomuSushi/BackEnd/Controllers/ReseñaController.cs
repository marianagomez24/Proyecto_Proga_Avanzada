using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReseñaController : ControllerBase
    {
        IReseñaService _reseñaService;
        public ReseñaController(IReseñaService reseñaService)
        {
            _reseñaService = reseñaService;
        }

        // GET: api/<ReseñaController>
        [HttpGet]
        public IEnumerable<ReseñaDTO> Get()
        {
            return _reseñaService.GetReseñas();
        }

        // GET api/<ReseñaController>/5
        [HttpGet("{id}")]
        public ReseñaDTO Get(int id)
        {
            return _reseñaService.GetReseñaById(id);
        }

        // POST api/<ReseñaController>
        [HttpPost]
        public void Post([FromBody]ReseñaDTO reseña)
        {
            _reseñaService.Add(reseña);
        }

        // PUT api/<ReseñaController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] ReseñaDTO reseña)
        {
            _reseñaService.Update(reseña);
        }

        // DELETE api/<ReseñaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _reseñaService.Delete(id);
        }
    }
}
