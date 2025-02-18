using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class MetodoPago
{
    public int IdMetodo { get; set; }

    public string TipoMetodo { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
