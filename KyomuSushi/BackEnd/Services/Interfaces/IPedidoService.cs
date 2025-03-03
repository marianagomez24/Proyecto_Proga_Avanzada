using BackEnd.DTO;
using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IPedidoService
    {
        void Add(PedidoDTO pago);
        void Update(PedidoDTO pago);
        void Delete(int id);
        List<PedidoDTO> GetPedidos();
        PedidoDTO GetPedidoById(int id);
    }
}
