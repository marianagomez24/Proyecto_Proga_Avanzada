using DAL.Interfaces;
using Entities.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class DetalleDAL : DALGenericoImpl<DetallePedido>, IDetalleDAL
    {
        public KyomudbContext _context;

        public DetalleDAL(KyomudbContext context) : base(context)
        {
            _context = context;

        }

        public List<DetallePedido> GetAllDetalles()
        {
            return _context.DetallePedidos
                .Select(d => new DetallePedido
                {
                    IdDetallePedido = d.IdDetallePedido,
                    IdPedido = d.IdPedido,
                    IdPlatillo = d.IdPlatillo,
                    Cantidad = d.Cantidad
                })
                .ToList();
        }

        public DetallePedido GetDetalleById(int idDetallePedido)
        {
            return _context.DetallePedidos
                .Where(d => d.IdDetallePedido == idDetallePedido)
                .Select(d => new DetallePedido
                {
                    IdDetallePedido = d.IdDetallePedido,
                    IdPedido = d.IdPedido,
                    IdPlatillo = d.IdPlatillo,
                    Cantidad = d.Cantidad
                })
                .FirstOrDefault();
        }
    }
}
