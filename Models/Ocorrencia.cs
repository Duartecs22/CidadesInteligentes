using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SegurancaPublicaApi.Models;

public class Ocorrencia
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    public string Descricao { get; set; } = string.Empty;
    public string Localizacao { get; set; } = string.Empty;
    public DateTime Data { get; set; }
}
