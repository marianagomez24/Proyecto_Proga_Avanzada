using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int IdRol { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Telefono { get; set; }

    public string CorreoElectronico { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Imagen { get; set; }

    public virtual Rol IdRolNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<Reseña> Reseñas { get; set; } = new List<Reseña>();
}
