using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class RolService : IRolService
    {
        IUnidadDeTrabajo _unidadDeTrabajo;

        public RolService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        Rol Convertir(RolDTO rol)
        {
            return new Rol
            {

            };
        }

        RolDTO Convertir(Rol rol)
        {
            return new RolDTO
            {

            };
        }

        public RolDTO Add(RolDTO rol)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public RolDTO GetRolById(int id)
        {
            throw new NotImplementedException();
        }

        public List<RolDTO> GetRoles()
        {
            throw new NotImplementedException();
        }

        public RolDTO Update(RolDTO rol)
        {
            throw new NotImplementedException();
        }
    }
}
