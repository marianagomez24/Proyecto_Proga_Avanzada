using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        ICategoriaService _categoriaService;
        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        // GET: api/<CategoriaController>
        [HttpGet]
        public IEnumerable<CategoriaDTO> Get()
        {
            return _categoriaService.GetCategoria();
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public CategoriaDTO Get(int id)
        {
            return _categoriaService.GetCategoriaById(id);
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public void Post([FromBody]CategoriaDTO categoria)
        {
            _categoriaService.Add(categoria);
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] CategoriaDTO categoria)
        {
            _categoriaService.Update(categoria);
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categoriaService.Delete(id);
        }
    }
}
