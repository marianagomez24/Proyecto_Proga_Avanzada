using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IMetodoPagoService
    {
        List<MetodoPagoDTO> GetMetodosPago();
        void Add(MetodoPagoDTO metodoPago);
        void Update(MetodoPagoDTO metodoPago);
        void Delete(int id);
        MetodoPagoDTO GetMetodoPagoById(int id);
    }
}
