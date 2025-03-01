using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class UsuarioService : IUsuarioService
    {
        IUnidadDeTrabajo _unidadDeTrabajo;

        public UsuarioService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        Usuario Convertir(UsuarioDTO usuario)
        {
            return new Usuario
            {

            };
        }

        UsuarioDTO Convertir(Usuario usuario)
        {
            return new UsuarioDTO
            {

            };
        }
        public UsuarioDTO Add(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UsuarioDTO GetUsuarioById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioDTO> GetUsuarios()
        {
            throw new NotImplementedException();
        }

        public UsuarioDTO Update(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }
    }
}
