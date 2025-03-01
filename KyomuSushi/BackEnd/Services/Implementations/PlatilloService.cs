using BackEnd.DTO;
using BackEnd.Services.Interfaces;
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

            };
        }

        PlatilloDTO Convertir(Platillo platillo)
        {
            return new PlatilloDTO
            {

            };
        }
        public PlatilloDTO Add(PlatilloDTO platillo)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public PlatilloDTO GetPlatilloById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PlatilloDTO> GetPlatillos()
        {
            throw new NotImplementedException();
        }

        public PlatilloDTO Update(PlatilloDTO platillo)
        {
            throw new NotImplementedException();
        }
    }
}
