using BackEnd.DTO;
using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IPagoService
    {
        void Add(PagoDTO pago);
        void Update(PagoDTO pago);
        void Delete(int id);
        List<PagoDTO> GetPagos();
        PagoDTO GetPagoById(int id);
    }
}
