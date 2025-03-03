using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
namespace DAL.Interfaces
{
    public interface IPagoDAL : IDALGenerico<Pago>
    {
        List<Pago> GetAllPagos();
    }
}
