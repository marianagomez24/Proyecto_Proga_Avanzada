using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnidadDeTrabajo: IDisposable
    {
        IPedidoDAL PedidoDAL { get; }
        IPagoDAL PagoDAL { get; }

        bool Complete();
    }
}
