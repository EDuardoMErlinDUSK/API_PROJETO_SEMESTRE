using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IPessoasRepositorio
    {
        Task<List<PessoasModel>> GetAll();

        Task<PessoasModel> GetById(int id);

        Task<PessoasModel> InsertPessoa(PessoasModel user);

        Task<PessoasModel> UpdatePessoa(PessoasModel user, int id);

        Task<bool> DeletePessoa(int id);
    }
}
