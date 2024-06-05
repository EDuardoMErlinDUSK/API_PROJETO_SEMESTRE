using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IObservacoesRepositorio
    {
        Task<List<ObservacoesModel>> GetAll();

        Task<ObservacoesModel> GetById(int id);

        Task<ObservacoesModel> InsertObservacoes(ObservacoesModel user);

        Task<ObservacoesModel> UpdateObservacoes(ObservacoesModel user, int id);

        Task<bool> DeleteObservacoes(int id);
    }
}
