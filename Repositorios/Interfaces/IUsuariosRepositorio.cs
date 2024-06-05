using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IUsuariosRepositorio
    {
        Task<List<UsuariosModel>> GetAll();

        Task<UsuariosModel> GetById(int id);

        Task<UsuariosModel> InsertUsuario(UsuariosModel user);

        Task<UsuariosModel> UpdateUsuario(UsuariosModel user, int id);

        Task<bool> DeleteUsuario(int id);
    }
}
