using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IRolService
    {
        List<RolDTO> GetRoles();
        void Add(RolDTO rol);
        void Update(RolDTO rol);
        void Delete(int id);
        RolDTO GetRolById(int id);
    }
}
