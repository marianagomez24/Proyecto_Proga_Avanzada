using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class Platillo
{
    public int IdPlatillo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public string? Imagen { get; set; }

    public int? IdCategoria { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual Categorium? IdCategoriaNavigation { get; set; }

    public virtual ICollection<Reseña> Reseñas { get; set; } = new List<Reseña>();
}
