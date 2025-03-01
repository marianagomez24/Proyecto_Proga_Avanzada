using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public IPagoDAL PagoDAL { get; set; }
        public IPedidoDAL PedidoDAL { get; set; }

        private KyomuDbContext _context;

        public UnidadDeTrabajo(KyomuDbContext context,
                        IPagoDAL pagoDAL,
                        IPedidoDAL pedidoDAL)


            {
                this._context = context;
                this.PagoDAL = pagoDAL;
                 this.PedidoDAL = pedidoDAL;
            

        }
       

        public bool Complete()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
