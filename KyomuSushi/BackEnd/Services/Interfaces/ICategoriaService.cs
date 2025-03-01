using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface ICategoriaService
    {
        List<CategoriaDTO> GetCategoria();
        CategoriaDTO Add(CategoriaDTO categoria);
        CategoriaDTO Update(CategoriaDTO categoria);
        void Delete(int id);
        CategoriaDTO GetCategoriaById(int id);
    }
}
