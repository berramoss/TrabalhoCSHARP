# BarbeariaAPI

API RESTful desenvolvida para gerenciar agendamentos de uma barbearia. Esta aplicação permite cadastrar, listar, buscar e excluir agendamentos, utilizando C#, ASP.NET e Entity Framework Core com banco de dados SQLite.

---

## Funcionalidades

- Listar todos os agendamentos
- Buscar agendamento por ID
- Cadastrar novo agendamento
- Deletar agendamento por ID

---

## Modelo de Dados

A entidade principal é **Agendamento**, contendo os seguintes campos:

| Campo         | Tipo       | Descrição                         |
|---------------|------------|-----------------------------------|
| Id            | int        | Identificador único               |
| NomeCliente   | string     | Nome do cliente                   |
| Servico       | string     | Tipo de serviço (corte, barba...)|
| DataHora      | DateTime   | Data e hora do agendamento        |
| Telefone      | string     | Contato do cliente                |

---

## Tecnologias Utilizadas

- C# com ASP.NET Core
- Entity Framework Core
- SQLite
- .NET 9
- Visual Studio / VS Code

---

## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/BarbeariaAPI.git
   ```
2. Navegue até a pasta do projeto:
   ```bash
   cd BarbeariaAPI
   ```
3. Execute a aplicação:
   ```bash
   dotnet run
   ```

A API estará disponível em `http://localhost:5000` (ou a porta indicada no terminal).

---

## Endpoints da API

| Método | Rota                        | Descrição                       |
|--------|-----------------------------|---------------------------------|
| GET    | /api/agendamentos           | Listar todos os agendamentos   |
| GET    | /api/agendamentos/{id}      | Buscar agendamento por ID      |
| POST   | /api/agendamentos           | Adicionar novo agendamento     |
| DELETE | /api/agendamentos/{id}      | Deletar agendamento por ID     |

---

## Integrantes

- Arthur Crispim  
- Arthur Hernandes  
- Bernardo Ramos  
- Gustavo Castro

---
