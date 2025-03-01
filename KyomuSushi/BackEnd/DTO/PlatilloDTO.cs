using System.ComponentModel.DataAnnotations;

namespace BackEnd.DTO
{
    public class PlatilloDTO
    {
        public int IdPlatillo { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }

        public decimal Precio { get; set; }

        public string? Imagen { get; set; }

        public int? IdCategoria { get; set; }
    }
}
