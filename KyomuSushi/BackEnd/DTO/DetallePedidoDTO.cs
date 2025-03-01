namespace BackEnd.DTO
{
    public class DetallePedidoDTO
    {
        public int IdDetallePedido { get; set; }

        public int IdPedido { get; set; }

        public int IdPlatillo { get; set; }

        public int Cantidad { get; set; }
    }
}
