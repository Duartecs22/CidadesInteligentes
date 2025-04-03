# Projeto Cidades Inteligentes - API ASP.NET Core

Este projeto faz parte do desafio de **DevOps** da faculdade FIAP e implementa uma **API REST** em **C# (ASP.NET Core 8)** que se conecta ao **MongoDB**.  

Além disso, utilizei **Docker** para containerizar a aplicação e **GitHub Actions** para criar um pipeline de **CI/CD**, automatizando o processo de build e deploy da API.  

---

## **Tecnologias Utilizadas**
- **C# (ASP.NET Core 8)**
- **MongoDB**
- **Docker & Docker Compose**
- **GitHub Actions (CI/CD)**
- **Postman (Testes de API)**

---

## **Como rodar o projeto localmente?**

### **Pré-requisitos**
Antes de rodar o projeto, você precisa ter instalado:
- [Docker](https://www.docker.com/get-started)  
- [Git](https://git-scm.com/)  

### **Clonar o repositório**  
Abra o terminal e execute:
git clone https://github.com/SEU-USUARIO/SEU-REPOSITORIO.git
cd SEU-REPOSITORIO
docker-compose up --build

---

### **Testando a API**
Com a aplicação rodando, podemos testar os endpoints.
Endpoints disponíveis:

GET → Retorna todos os crimes cadastrados
http://localhost:5008/api/Crimes

POST → Cadastra um novo crime
http://localhost:5008/api/Crimes

Exemplo de JSON para cadastro:
{
  "tipo": "Roubo",
  "descricao": "Assalto a mão armada",
  "data": "2025-04-03T10:00:00"
}

---

### **Pipeline CI/CD - GitHub Actions**
Configurei um pipeline de CI/CD no GitHub Actions, que funciona assim:

- Toda vez que faço push na branch main, ele dispara o workflow.
- O pipeline faz build do código e executa os testes.
- Em seguida, a imagem Docker é construída e enviada para o Docker Hub automaticamente.

Arquivo de configuração do pipeline:
.github/workflows/main.yml