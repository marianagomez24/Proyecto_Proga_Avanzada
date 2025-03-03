namespace BackEnd.DTO
{
    public class CategoriaDTO
    {
        public int IdCategoria { get; set; }

        public string NombreCategoria { get; set; } = null!;

        public string? Descripcion { get; set; }
    }
}
