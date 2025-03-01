using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class PedidoService : IPedidoService
    {

        IUnidadDeTrabajo _unidadDeTrabajo;

        public PedidoService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        Pedido Convertir(PedidoDTO pedido)
        {
            return new Pedido
            {
                IdPedido = pedido.IdPedido,
                IdUsuario = pedido.IdUsuario,
                FechaEntrega = pedido.FechaEntrega,
                FechaPedido = pedido.FechaPedido,
                TipoEntrega = pedido.TipoEntrega,
                Total = pedido.Total,
                Estado = pedido.Estado
            };
        }
        PedidoDTO Convertir(Pedido pedido)
        {
            return new PedidoDTO
            {
                IdPedido = pedido.IdPedido,
                IdUsuario = pedido.IdUsuario,
                FechaEntrega = pedido.FechaEntrega,
                FechaPedido = pedido.FechaPedido,
                TipoEntrega = pedido.TipoEntrega,
                Total = pedido.Total,
                Estado = pedido.Estado
            };
        }

        public void Add(PedidoDTO pedido)
        {

            var pedidoEntity = Convertir(pedido);

            _unidadDeTrabajo.PedidoDAL.Add(pedidoEntity);
            _unidadDeTrabajo.Complete();
        }

        public void Delete(int id)
        {
            var pedido = new Pedido { IdPedido = id };
            _unidadDeTrabajo.PedidoDAL.Remove(pedido);
            _unidadDeTrabajo.Complete();
        }

        public List<PedidoDTO> GetPedidos()
        {
            var result = _unidadDeTrabajo.PedidoDAL.GetAllPedidos();

            List<PedidoDTO> pedidos = new List<PedidoDTO>();
            foreach (var item in result)
            {
                pedidos
                    .Add(Convertir(item));
            }
            return pedidos;
        }

        public void Update(PedidoDTO pedido)
        {
            var pedidoEntity = Convertir(pedido);
            _unidadDeTrabajo.PedidoDAL.Update(pedidoEntity);
            _unidadDeTrabajo.Complete();
        }

        public PedidoDTO GetPedidoById(int id)
        {
            var result = _unidadDeTrabajo.PedidoDAL.Get(id);
            return Convertir(result);

        }
    }
}

