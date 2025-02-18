using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string NombreCategoria { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Platillo> Platillos { get; set; } = new List<Platillo>();
}
