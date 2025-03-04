using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class MetodoPagoService : IMetodoPagoService
    {
        private readonly IUnidadDeTrabajo _unidadDeTrabajo;

        public MetodoPagoService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        private MetodoPago Convertir(MetodoPagoDTO metodo)
        {
            return new MetodoPago
            {
                IdMetodo = metodo.IdMetodo,
                TipoMetodo = metodo.TipoMetodo
            };
        }

        private MetodoPagoDTO Convertir(MetodoPago metodo)
        {
            return new MetodoPagoDTO
            {
                IdMetodo = metodo.IdMetodo,
                TipoMetodo = metodo.TipoMetodo
            };
        }

        public void Add(MetodoPagoDTO metodoPago)
        {
            var metodoEntity = Convertir(metodoPago);
            _unidadDeTrabajo.MetodoPagoDAL.Add(metodoEntity);
            _unidadDeTrabajo.Complete();
        }

        public void Delete(int id)
        {
            var metodo = new MetodoPago { IdMetodo = id };
            _unidadDeTrabajo.MetodoPagoDAL.Remove(metodo);
            _unidadDeTrabajo.Complete();
        }

        public List<MetodoPagoDTO> GetMetodosPago()
        {
            return _unidadDeTrabajo.MetodoPagoDAL.GetAll()
                .Select(m => Convertir(m))
                .ToList();
        }

        public void Update(MetodoPagoDTO metodoPago)
        {
            var metodoEntity = Convertir(metodoPago);
            _unidadDeTrabajo.MetodoPagoDAL.Update(metodoEntity);
            _unidadDeTrabajo.Complete();
        }

        public MetodoPagoDTO GetMetodoPagoById(int id)
        {
            var result = _unidadDeTrabajo.MetodoPagoDAL.Get(id);
            return Convertir(result);
        }
    }
}