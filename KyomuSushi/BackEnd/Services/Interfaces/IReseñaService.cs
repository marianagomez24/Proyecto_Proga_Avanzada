using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IReseñaService
    {
        List<ReseñaDTO> GetReseñas();
        ReseñaDTO Add(ReseñaDTO reseña);
        ReseñaDTO Update(ReseñaDTO reseña);
        void Delete(int id);
        ReseñaDTO GetReseñaById(int id);
    }
}
