using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
namespace DAL.Interfaces
{
    public interface IPedidoDAL : IDALGenerico<Pedido>
    {
        List<Pedido> GetAllPedidos();
    }
}
