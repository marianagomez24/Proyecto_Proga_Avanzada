using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<UsuarioDTO> Get()
        {
            return _usuarioService.GetUsuarios();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public UsuarioDTO Get(int id)
        {
            return _usuarioService.GetUsuarioById(id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody]UsuarioDTO usuario)
        {
            _usuarioService.Add(usuario);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] UsuarioDTO usuario)
        {
            _usuarioService.Update(usuario);
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _usuarioService.Delete(id);
        }
    }
}
