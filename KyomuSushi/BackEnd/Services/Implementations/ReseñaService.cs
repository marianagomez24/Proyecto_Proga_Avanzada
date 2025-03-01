using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
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
                IdReseña = reseña.IdReseña,
                IdUsuario = reseña.IdUsuario,
                IdPlatillo = reseña.IdPlatillo,
                Calificacion = reseña.Calificacion,
                Comentario = reseña.Comentario
            };
        }

        ReseñaDTO Convertir(Reseña reseña)
        {
            return new ReseñaDTO
            {
                IdReseña = reseña.IdReseña,
                IdUsuario = reseña.IdUsuario,
                IdPlatillo = reseña.IdPlatillo,
                Calificacion = reseña.Calificacion,
                Comentario = reseña.Comentario

            };
        }

        public void Add(ReseñaDTO reseña)
        {
            var reseñaEntity = Convertir(reseña);
            _unidadDeTrabajo.ReseñaDAL.Add(reseñaEntity);
            _unidadDeTrabajo.Complete();
        }

        public void Delete(int id)
        {
            var reseña = new Reseña { IdReseña = id };
            _unidadDeTrabajo.ReseñaDAL.Remove(reseña);
            _unidadDeTrabajo.Complete();
        }

        public ReseñaDTO GetReseñaById(int id)
        {
            var result = _unidadDeTrabajo.ReseñaDAL.Get(id);
            return Convertir(result);
        }

        public List<ReseñaDTO> GetReseñas()
        {
            var result = _unidadDeTrabajo.ReseñaDAL.GetAll();
            List<ReseñaDTO> reseñas = new List<ReseñaDTO>();
            foreach (var item in result)
            {
                reseñas.Add(Convertir(item));
            }
            return reseñas;
        }

        public void Update(ReseñaDTO reseña)
        {
            var reseñaEntity = Convertir(reseña);
            _unidadDeTrabajo.ReseñaDAL.Update(reseñaEntity);
            _unidadDeTrabajo.Complete();
        }
    }
}
