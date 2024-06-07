# Sistema de Controle de Estoque de Mercadorias em C#

Este é um sistema de controle de estoque de mercadorias desenvolvido em C#.

## Tecnologias Utilizadas

- ASP.NET Core
- Vue.js
- Vuetify
- Entity Framework Core
- SQL Server (ou outro banco de dados utilizado)

## Pré-requisitos

Antes de começar, certifique-se de ter instalado o seguinte:

- Node.js
- .NET Core SDK
- Visual Studio Code (ou IDE de sua preferência)
- SQL Server (ou outro banco de dados)

## Instalação

1. Clone este repositório: `git clone https://github.com/seu-usuario/nome-do-projeto.git`
2. Navegue até o diretório do projeto: `cd nome-do-projeto`
3. Instale as dependências do front-end: `npm install`
4. Abra o projeto no Visual Studio Code: `code .`
5. Abra o terminal no Visual Studio Code e navegue até o diretório do projeto back-end: `cd backend`
6. Instale as dependências do back-end: `dotnet restore`

## Configuração

1. Configure a string de conexão com o banco de dados no arquivo `appsettings.json`.
2. Execute as migrações do banco de dados para criar o esquema no banco de dados: `dotnet ef database update`.
3. Inicie o servidor back-end: `dotnet run`.
4. Em outro terminal, navegue até o diretório do projeto front-end: `cd frontend`.
5. Inicie o servidor front-end: `npm run serve`.

## Uso

- Acesse a aplicação no navegador através do endereço: `http://localhost:8080` (ou outra porta configurada).
- Navegue pela aplicação para visualizar e interagir com as funcionalidades de controle de estoque.

## Contribuição

Contribuições são bem-vindas! Para sugestões, melhorias ou correções, abra uma issue ou envie um pull request.

