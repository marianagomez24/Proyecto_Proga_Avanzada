using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class PagoService : IPagoService
    {

        IUnidadDeTrabajo _unidadDeTrabajo;

        public PagoService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        Pago Convertir(PagoDTO pago)
        {
            return new Pago
            {
                IdPago = pago.IdPago,
                IdPedido = pago.IdPedido,
                IdMetodo = pago.IdMetodo,
                Monto = pago.Monto,
                FechaPago = pago.FechaPago
            };
        }
        PagoDTO Convertir(Pago pago)
        {
            return new PagoDTO
            {
                IdPago = pago.IdPago,
                IdPedido = pago.IdPedido,
                IdMetodo = pago.IdMetodo,
                Monto = pago.Monto,
                FechaPago = pago.FechaPago
            };
        }

        public void Add(PagoDTO pago)
        {

            var pagoEntity = Convertir(pago);

            _unidadDeTrabajo.PagoDAL.Add(pagoEntity);
            _unidadDeTrabajo.Complete();
        }

        public void Delete(int id)
        {
            var pago = new Pago { IdPago = id };
            _unidadDeTrabajo.PagoDAL.Remove(pago);
            _unidadDeTrabajo.Complete();
        }

        public List<PagoDTO> GetPagos()
        {
            var result = _unidadDeTrabajo.PagoDAL.GetAllPagos();

            List<PagoDTO> pagos = new List<PagoDTO>();
            foreach (var item in result)
            {
                pagos
                    .Add(Convertir(item));
            }
            return pagos;
        }

        public void Update(PagoDTO pago)
        {
            var pagoEntity = Convertir(pago);
            _unidadDeTrabajo.PagoDAL.Update(pagoEntity);
            _unidadDeTrabajo.Complete();
        }

        public PagoDTO GetPagoById(int id)
        {
            var result = _unidadDeTrabajo.PagoDAL.Get(id);
            return Convertir(result);

        }
    }
}

