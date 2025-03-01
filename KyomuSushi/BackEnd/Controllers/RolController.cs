using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        IRolService _rolService;
        public RolController(IRolService rolService)
        {
            _rolService = rolService;
        }

        // GET: api/<RolController>
        [HttpGet]
        public IEnumerable<RolDTO> Get()
        {
            return _rolService.GetRoles();
        }

        // GET api/<RolController>/5
        [HttpGet("{id}")]
        public RolDTO Get(int id)
        {
            return _rolService.GetRolById(id);
        }

        // POST api/<RolController>
        [HttpPost]
        public void Post([FromBody]RolDTO rol)
        {
            _rolService.Add(rol);
        }

        // PUT api/<RolController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] RolDTO rol)
        {
            _rolService.Update(rol);
        }

        // DELETE api/<RolController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _rolService.Delete(id);
        }
    }
}
