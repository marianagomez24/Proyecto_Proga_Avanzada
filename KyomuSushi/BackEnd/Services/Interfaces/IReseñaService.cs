using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IReseñaService
    {
        List<ReseñaDTO> GetReseñas();
        void Add(ReseñaDTO reseña);
        void Update(ReseñaDTO reseña);
        void Delete(int id);
        ReseñaDTO GetReseñaById(int id);
    }
}
