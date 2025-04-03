using MongoDB.Driver;
using SegurancaPublicaApi.Data;
using SegurancaPublicaApi.Models;

namespace SegurancaPublicaApi.Services
{
    public class OcorrenciaService : IOcorrenciaService
    {
        private readonly IMongoCollection<Ocorrencia> _ocorrencias;

        public OcorrenciaService(MongoDbContext dbContext)
        {
            _ocorrencias = dbContext.GetCollection<Ocorrencia>("ocorrencias");
        }

        public async Task<List<Ocorrencia>> GetAllAsync() =>
            await _ocorrencias.Find(_ => true).ToListAsync();

        public async Task<Ocorrencia> GetByIdAsync(string id) =>
            await _ocorrencias.Find(o => o.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Ocorrencia ocorrencia) =>
            await _ocorrencias.InsertOneAsync(ocorrencia);

        public async Task UpdateAsync(string id, Ocorrencia ocorrencia) =>
            await _ocorrencias.ReplaceOneAsync(o => o.Id == id, ocorrencia);

        public async Task DeleteAsync(string id) =>
            await _ocorrencias.DeleteOneAsync(o => o.Id == id);
    }
}

