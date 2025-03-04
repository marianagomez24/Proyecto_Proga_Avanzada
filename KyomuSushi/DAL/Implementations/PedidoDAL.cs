using Entities.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class PedidoDAL : DALGenericoImpl<Pedido>, IPedidoDAL
    {
        public KyomudbContext _context;

        public PedidoDAL(KyomudbContext context) : base(context)
        {
            _context = context;

        }

        public List<Pedido> GetAllPedidos()
        {
            return _context.Pedidos
                .Select(e => new Pedido
                {
                    IdPedido = e.IdPedido,
                    IdUsuario = e.IdUsuario,
                    FechaEntrega = e.FechaEntrega,
                    FechaPedido = e.FechaPedido,
                    TipoEntrega = e.TipoEntrega,
                    Total = e.Total,
                    Estado = e.Estado,

                })
                .ToList();
        }

        public bool Add(Pedido entity)
        {
            try
            {
                _context.Pedidos.Add(new Pedido
                {
                    IdPedido = entity.IdPedido,
                    IdUsuario = entity.IdUsuario,
                    FechaEntrega = entity.FechaEntrega,
                    FechaPedido = entity.FechaPedido,
                    TipoEntrega = entity.TipoEntrega,
                    Total = entity.Total,
                    Estado = entity.Estado,
                });
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }
    } 
}
