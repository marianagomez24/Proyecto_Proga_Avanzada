using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IPlatilloService
    {
        List<PlatilloDTO> GetPlatillos();
        void Add(PlatilloDTO platillo);
        void Update(PlatilloDTO platillo);
        void Delete(int id);
        PlatilloDTO GetPlatilloById(int id);
    }
}
