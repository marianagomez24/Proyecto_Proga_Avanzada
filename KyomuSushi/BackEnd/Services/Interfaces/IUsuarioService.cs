using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IUsuarioService
    {
        List<UsuarioDTO> GetUsuarios();
        void Add(UsuarioDTO usuario);
        void Update(UsuarioDTO usuario);
        void Delete(int id);
        UsuarioDTO GetUsuarioById(int id);
    }
}
