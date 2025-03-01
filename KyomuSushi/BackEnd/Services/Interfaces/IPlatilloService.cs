using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IPlatilloService
    {
        List<PlatilloDTO> GetPlatillos();
        PlatilloDTO Add(PlatilloDTO platillo);
        PlatilloDTO Update(PlatilloDTO platillo);
        void Delete(int id);
        PlatilloDTO GetPlatilloById(int id);
    }
}
