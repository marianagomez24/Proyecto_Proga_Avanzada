using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface ICategoriaService
    {
        List<CategoriaDTO> GetCategoria();
        void Add(CategoriaDTO categoria);
        void Update(CategoriaDTO categoria);
        void Delete(int id);
        CategoriaDTO GetCategoriaById(int id);
    }
}
