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
        ICategoriaDAL CategoriaDAL { get; }
        IPlatilloDAL PlatilloDAL { get; }
        IReseñaDAL ReseñaDAL { get; }
        IRolDAL RolDAL { get; }
        IUsuarioDAL UsuarioDAL { get; }
        IDetalleDAL DetalleDAL { get; }
        IMetodoPagoDAL MetodoPagoDAL { get; }
        bool Complete();
    }
}
