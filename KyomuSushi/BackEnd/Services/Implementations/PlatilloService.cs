using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class PlatilloService : IPlatilloService
    {
        IUnidadDeTrabajo _unidadDeTrabajo;

        public PlatilloService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        Platillo Convertir(PlatilloDTO platillo)
        {
            return new Platillo
            {
                IdPlatillo = platillo.IdPlatillo,
                Nombre = platillo.Nombre,
                Descripcion = platillo.Descripcion,
                Precio = platillo.Precio,
                Imagen= platillo.Imagen,
                IdCategoria = platillo.IdCategoria

            };
        }

        PlatilloDTO Convertir(Platillo platillo)
        {
            return new PlatilloDTO
            {
                IdPlatillo = platillo.IdPlatillo,
                Nombre = platillo.Nombre,
                Descripcion = platillo.Descripcion,
                Precio = platillo.Precio,
                Imagen = platillo.Imagen,
                IdCategoria = platillo.IdCategoria

            };
        }
        public void Add(PlatilloDTO platillo)
        {
            var platilloEntity = Convertir(platillo);
            _unidadDeTrabajo.PlatilloDAL.Add(platilloEntity);
            _unidadDeTrabajo.Complete();
        }

        public void Delete(int id)
        {
            var platillo = new Platillo { IdPlatillo = id };
            _unidadDeTrabajo.PlatilloDAL.Remove(platillo);
            _unidadDeTrabajo.Complete();
        }

        public PlatilloDTO GetPlatilloById(int id)
        {
            var result = _unidadDeTrabajo.PlatilloDAL.Get(id);
            return Convertir(result);
        }

        public List<PlatilloDTO> GetPlatillos()
        {
            var result = _unidadDeTrabajo.PlatilloDAL.GetAll();
            List<PlatilloDTO> platillos = new List<PlatilloDTO>();
            foreach (var item in result)
            {
                platillos.Add(Convertir(item));
            }
            return platillos;
        }

        public void Update(PlatilloDTO platillo)
        {
            var platilloEntity = Convertir(platillo);
            _unidadDeTrabajo.PlatilloDAL.Update(platilloEntity);
            _unidadDeTrabajo.Complete();
        }
        
    }
}
