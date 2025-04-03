using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SegurancaPublicaApi.Models;

public class Crime
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    public string Tipo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataOcorrencia { get; set; }
}
