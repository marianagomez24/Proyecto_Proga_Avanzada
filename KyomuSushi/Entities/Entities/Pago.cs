using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class Pago
{
    public int IdPago { get; set; }

    public int IdPedido { get; set; }

    public int IdMetodo { get; set; }

    public decimal Monto { get; set; }

    public DateTime FechaPago { get; set; }

    public virtual MetodoPago IdMetodoNavigation { get; set; } = null!;

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;
}
