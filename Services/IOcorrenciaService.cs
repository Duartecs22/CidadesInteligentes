using SegurancaPublicaApi.Models;

namespace SegurancaPublicaApi.Services
{
    public interface IOcorrenciaService
    {
        Task<List<Ocorrencia>> GetAllAsync();
        Task<Ocorrencia> GetByIdAsync(string id);
        Task CreateAsync(Ocorrencia ocorrencia);
        Task UpdateAsync(string id, Ocorrencia ocorrencia);
        Task DeleteAsync(string id);
    }
}
