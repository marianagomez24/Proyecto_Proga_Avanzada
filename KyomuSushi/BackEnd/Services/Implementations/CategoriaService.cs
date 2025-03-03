using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class CategoriaService : ICategoriaService
    {
        IUnidadDeTrabajo _unidadDeTrabajo;

        public CategoriaService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        Categorium Convertir(CategoriaDTO categoria)
        {
            return new Categorium
            {
                IdCategoria = categoria.IdCategoria,
                NombreCategoria = categoria.NombreCategoria,
                Descripcion = categoria.Descripcion
            };
        }

        CategoriaDTO Convertir(Categorium categoria)
        {
            return new CategoriaDTO
            {
                IdCategoria = categoria.IdCategoria,
                NombreCategoria = categoria.NombreCategoria,
                Descripcion = categoria.Descripcion

            };
        }
        public void Add(CategoriaDTO categoria)
        {
            var categoriaEntity = Convertir(categoria);
            _unidadDeTrabajo.CategoriaDAL.Add(categoriaEntity);
            _unidadDeTrabajo.Complete();
        }

        public void Delete(int id)
        {
            var categoria = new Categorium { IdCategoria = id };
            _unidadDeTrabajo.CategoriaDAL.Remove(categoria);
            _unidadDeTrabajo.Complete();
        }

        public List<CategoriaDTO> GetCategoria()
        {
            var result = _unidadDeTrabajo.CategoriaDAL.GetAll();
            List<CategoriaDTO> categorias = new List<CategoriaDTO>();
            foreach (var item in result)
            {
                categorias.Add(Convertir(item));
            }
            return categorias;
        }

        public void Update(CategoriaDTO categoria)
        {
            var categoriaEntity = Convertir(categoria);
            _unidadDeTrabajo.CategoriaDAL.Update(categoriaEntity);
            _unidadDeTrabajo.Complete();
        }

        public CategoriaDTO GetCategoriaById(int id)
        {
            var result = _unidadDeTrabajo.CategoriaDAL.Get(id);
            return Convertir(result);
        }
    }
}
