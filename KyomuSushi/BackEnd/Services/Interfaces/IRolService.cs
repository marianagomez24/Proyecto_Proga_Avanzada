using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IRolService
    {
        List<RolDTO> GetRoles();
        RolDTO Add(RolDTO rol);
        RolDTO Update(RolDTO rol);
        void Delete(int id);
        RolDTO GetRolById(int id);
    }
}
