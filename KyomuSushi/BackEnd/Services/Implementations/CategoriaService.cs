using BackEnd.DTO;
using BackEnd.Services.Interfaces;
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

        Categoria Convertir(CategoriaDTO categoria)
        {
            return new Categoria
            {
                
            };
        }

        CategoriaDTO Convertir(Categoria categoria)
        {
            return new CategoriaDTO
            {

            };
        }
        public CategoriaDTO Add(CategoriaDTO categoria)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoriaDTO> GetCategoria()
        {
            throw new NotImplementedException();
        }

        public CategoriaDTO Update(CategoriaDTO categoria)
        {
            throw new NotImplementedException();
        }

        public CategoriaDTO GetCategoriaById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
