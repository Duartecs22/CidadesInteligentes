# Etapa 1: Construção da aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia os arquivos do projeto para dentro do container
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o /out

# Etapa 2: Configuração do runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copia os arquivos da primeira etapa
COPY --from=build /out ./

# Define a porta que será exposta
EXPOSE 5008

# Comando para rodar a aplicação
ENTRYPOINT ["dotnet", "SegurancaPublicaApi.dll"]
