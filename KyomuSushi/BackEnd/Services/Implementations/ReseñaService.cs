using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class ReseñaService : IReseñaService
    {
        IUnidadDeTrabajo _unidadDeTrabajo;

        public ReseñaService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }
        Reseña Convertir(ReseñaDTO reseña)
        {
            return new Reseña
            {

            };
        }

        ReseñaDTO Convertir(Reseña reseña)
        {
            return new ReseñaDTO
            {

            };
        }
        public ReseñaDTO Add(ReseñaDTO reseña)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ReseñaDTO GetReseñaById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReseñaDTO> GetReseñas()
        {
            throw new NotImplementedException();
        }

        public ReseñaDTO Update(ReseñaDTO reseña)
        {
            throw new NotImplementedException();
        }
    }
}
