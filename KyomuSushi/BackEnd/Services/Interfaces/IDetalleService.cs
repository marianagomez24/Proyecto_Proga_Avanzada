using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IDetalleService
    {
        List<DetallePedidoDTO> GetDetalles();
        void Add(DetallePedidoDTO detalle);
        void Update(DetallePedidoDTO detalle);
        void Delete(int id);
        DetallePedidoDTO GetDetalleById(int id);
    }
}
