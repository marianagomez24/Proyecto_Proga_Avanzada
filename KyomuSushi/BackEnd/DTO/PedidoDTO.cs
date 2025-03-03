namespace BackEnd.DTO
{
    public class PedidoDTO
    {
        public int IdPedido { get; set; }

        public int IdUsuario { get; set; }

        public DateTime FechaPedido { get; set; }

        public DateTime? FechaEntrega { get; set; }

        public string? TipoEntrega { get; set; }

        public decimal Total { get; set; }

        public string Estado { get; set; } = null!;

    }
}
