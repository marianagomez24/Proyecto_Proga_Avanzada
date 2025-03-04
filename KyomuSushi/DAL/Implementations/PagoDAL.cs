using Entities.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class PagoDAL : DALGenericoImpl<Pago>, IPagoDAL
    {
    
        public KyomudbContext _context;
   
         public PagoDAL(KyomudbContext context) : base(context)
       {
            _context = context;
       }
        public List<Pago> GetAllPagos()
        {
            return _context.Pagos
                .Select(e => new Pago
                {
                    IdPago = e.IdPago,
                    IdPedido = e.IdPedido,
                    IdMetodo = e.IdMetodo,
                    Monto = e.Monto,
                    FechaPago = e.FechaPago
                })
                .ToList();
        }

        public bool Add(Pago entity)
        {
            try
            {
                _context.Pagos.Add(new Pago
                {
                    IdPago = entity.IdPago,
                    IdPedido = entity.IdPedido,
                    IdMetodo = entity.IdMetodo,
                    Monto = entity.Monto,
                    FechaPago = entity.FechaPago
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
