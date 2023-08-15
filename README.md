# ProductsAPI

Este é um projeto de API simples desenvolvido em C# usando ASP.NET e Entity Framework. O projeto implementa operações CRUD (Create, Read, Update, Delete) para gerenciar recursos através de endpoints HTTP.

Pré-requisitos
Certifique-se de ter as seguintes ferramentas instaladas em sua máquina antes de prosseguir:

- Visual Studio (ou Visual Studio Code) com suporte a desenvolvimento em C# e ASP.NET.
- .NET Core SDK.
- Um banco de dados compatível (por exemplo, SQL Server, SQLite) configurado para uso com o Entity Framework.

## Configuração do Ambiente

Clone este repositório para sua máquina local:

`git clone https://github.com/luckraw/ProductsAPI.git`

- Abra o projeto em sua IDE (Visual Studio ou Visual Studio Code).
- Configure a conexão com o banco de dados no arquivo appsettings.json:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "sua-string-de-conexao"
  },
  // ...
}
```

- Abra um terminal na raiz do projeto e execute as migrações do Entity Framework para criar as tabelas no banco de dados:
`dotnet ef database update`

### Estrutura do Projeto
O projeto possui a seguinte estrutura de diretórios:

- Controllers: Contém os controladores da API responsáveis por definir os endpoints e as operações CRUD.
- Models: Define as classes de modelo que representam os recursos da API.
- Data: Lida com a configuração do banco de dados e o contexto do Entity Framework.

