using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IUsuarioService
    {
        List<UsuarioDTO> GetUsuarios();
        UsuarioDTO Add(UsuarioDTO usuario);
        UsuarioDTO Update(UsuarioDTO usuario);
        void Delete(int id);
        UsuarioDTO GetUsuarioById(int id);
    }
}
