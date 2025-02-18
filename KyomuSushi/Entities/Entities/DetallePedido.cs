using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class DetallePedido
{
    public int IdDetallePedido { get; set; }

    public int IdPedido { get; set; }

    public int IdPlatillo { get; set; }

    public int Cantidad { get; set; }

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;

    public virtual Platillo IdPlatilloNavigation { get; set; } = null!;
}
