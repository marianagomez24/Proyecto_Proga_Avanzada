namespace BackEnd.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }

        public int IdRol { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Telefono { get; set; }

        public string CorreoElectronico { get; set; } = null!;

        public string Contraseña { get; set; } = null!;

        public string? Direccion { get; set; }

        public string? Imagen { get; set; }
    }
}
