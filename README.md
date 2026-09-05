# Trabalho 1 - Desenvolvimento Web com .NET

Aplicação ASP.NET Core MVC para gerenciamento de pacientes, utilizando Entity Framework Core e PostgreSQL.

## Funcionalidades

- Listagem de pacientes
- Cadastro de paciente
- Edição de paciente
- Remoção de paciente
- Visualização de detalhes
- Data Annotations para validação
- Migration para criação da tabela Pacientes
- Seeding com pacientes iniciais

## Paciente

A entidade possui Nome, CPF, Telefone, Endereço e Data de Nascimento.

## Banco de dados

O projeto utiliza PostgreSQL com o provedor `Npgsql.EntityFrameworkCore.PostgreSQL`.

Antes de executar, substitua `Senha` pela senha do usuário `postgres` configurada na sua máquina no arquivo `appsettings.json`:

```json
"DefaultConnection": "Host=localhost;Port=5432;Database=agendamento_db;Username=postgres;Password=Senha"
```

Depois execute:

```bash
dotnet restore
dotnet ef database update
dotnet run
```

Se o comando `dotnet ef` não estiver instalado:

```bash
dotnet tool install --global dotnet-ef
```
