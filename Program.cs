using SegurancaPublicaApi.Data;
using SegurancaPublicaApi.Services;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Configuração do MongoDB
builder.Services.AddSingleton<MongoDbContext>();
builder.Services.AddScoped<ICrimeService, CrimeService>();
builder.Services.AddScoped<IOcorrenciaService, OcorrenciaService>();

// Configuração da API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
