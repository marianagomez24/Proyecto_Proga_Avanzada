using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd.Services.Implementations
{
    public class DetalleService : IDetalleService
    {
        private readonly IUnidadDeTrabajo _unidadDeTrabajo;

        public DetalleService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        private DetallePedido Convertir(DetallePedidoDTO detalle)
        {
            return new DetallePedido
            {
                IdDetallePedido = detalle.IdDetallePedido,
                IdPedido = detalle.IdPedido,
                IdPlatillo = detalle.IdPlatillo,
                Cantidad = detalle.Cantidad
            };
        }

        private DetallePedidoDTO Convertir(DetallePedido detalle)
        {
            return new DetallePedidoDTO
            {
                IdDetallePedido = detalle.IdDetallePedido,
                IdPedido = detalle.IdPedido,
                IdPlatillo = detalle.IdPlatillo,
                Cantidad = detalle.Cantidad
            };
        }

        public void Add(DetallePedidoDTO detalle)
        {
            var detalleEntity = Convertir(detalle);
            _unidadDeTrabajo.DetalleDAL.Add(detalleEntity);
            _unidadDeTrabajo.Complete();
        }

        public void Delete(int id)
        {
            var detalle = _unidadDeTrabajo.DetalleDAL.Get(id);
            if (detalle != null)
            {
                _unidadDeTrabajo.DetalleDAL.Remove(detalle);
                _unidadDeTrabajo.Complete();
            }
        }

        public List<DetallePedidoDTO> GetDetalles()
        {
            return _unidadDeTrabajo.DetalleDAL.GetAll()
                .Select(d => Convertir(d))
                .ToList();
        }

        public void Update(DetallePedidoDTO detalle)
        {
            var detalleEntity = Convertir(detalle);
            _unidadDeTrabajo.DetalleDAL.Update(detalleEntity);
            _unidadDeTrabajo.Complete();
        }

        public DetallePedidoDTO GetDetalleById(int id)
        {
            var result = _unidadDeTrabajo.DetalleDAL.Get(id);
            return result != null ? Convertir(result) : null;
        }
    }
}
