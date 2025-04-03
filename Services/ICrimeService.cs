using SegurancaPublicaApi.Models;

namespace SegurancaPublicaApi.Services
{
    public interface ICrimeService
    {
        Task<List<Crime>> GetAllAsync();
        Task<Crime> GetByIdAsync(string id);
        Task CreateAsync(Crime crime);
        Task UpdateAsync(string id, Crime crime);
        Task DeleteAsync(string id);
    }
}
