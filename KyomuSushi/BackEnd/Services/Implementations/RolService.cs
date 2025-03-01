using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
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
                IdRol = rol.IdRol,
                NombreRol = rol.NombreRol,
                Descripcion = rol.Descripcion

            };
        }

        RolDTO Convertir(Rol rol)
        {
            return new RolDTO
            {
                IdRol = rol.IdRol,
                NombreRol = rol.NombreRol,
                Descripcion = rol.Descripcion
            };
        }
        public void Add(RolDTO rol)
        {
            var rolEntity = Convertir(rol);
            _unidadDeTrabajo.RolDAL.Add(rolEntity);
            _unidadDeTrabajo.Complete();
        }

        public void Delete(int id)
        {
            var rol = new Rol { IdRol = id };
            _unidadDeTrabajo.RolDAL.Remove(rol);
            _unidadDeTrabajo.Complete();
        }

        public RolDTO GetRolById(int id)
        {
            var result = _unidadDeTrabajo.RolDAL.Get(id);
            return Convertir(result);
        }

        public List<RolDTO> GetRoles()
        {
            var result = _unidadDeTrabajo.RolDAL.GetAll();
            List<RolDTO> roles = new List<RolDTO>();
            foreach (var item in result)
            {
                roles.Add(Convertir(item));
            }
            return roles;
        }

        public void Update(RolDTO rol)
        {
            var rolEntity = Convertir(rol);
            _unidadDeTrabajo.RolDAL.Update(rolEntity);
            _unidadDeTrabajo.Complete();
        }
    }
}
