using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class Rol
{
    public int IdRol { get; set; }

    public string NombreRol { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
