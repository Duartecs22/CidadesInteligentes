using MongoDB.Driver;
using SegurancaPublicaApi.Data;
using SegurancaPublicaApi.Services;
using SegurancaPublicaApi.Models;

namespace SegurancaPublicaApi.Services
{
    public class CrimeService : ICrimeService
    {
        private readonly IMongoCollection<Crime> _crimes;

        public CrimeService(MongoDbContext dbContext)
        {
            _crimes = dbContext.GetCollection<Crime>("crimes");
        }

        public async Task<List<Crime>> GetAllAsync() =>
            await _crimes.Find(_ => true).ToListAsync();

        public async Task<Crime> GetByIdAsync(string id) =>
            await _crimes.Find(c => c.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Crime crime) =>
            await _crimes.InsertOneAsync(crime);

        public async Task UpdateAsync(string id, Crime crime) =>
            await _crimes.ReplaceOneAsync(c => c.Id == id, crime);

        public async Task DeleteAsync(string id) =>
            await _crimes.DeleteOneAsync(c => c.Id == id);
    }
}
