using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class Reseña
{
    public int IdReseña { get; set; }

    public int IdUsuario { get; set; }

    public int IdPlatillo { get; set; }

    public int Calificacion { get; set; }

    public string? Comentario { get; set; }

    public virtual Platillo IdPlatilloNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
