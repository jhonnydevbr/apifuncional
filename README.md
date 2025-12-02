# API FUNCIONAL .NET


API Funcional é uma API em .NET completa, construída como projeto de consolidação de conceitos e também para servir como template reutilizável em futuros projetos.
Ela implementa uma arquitetura típica de APIs modernas, incluindo Controllers, Models, Data, Migrations e integração com SQL Server.
Além disso, inclui recursos de segurança profissional utilizando Identity, JWT, autenticação e autorização por roles.

# Tecnologias
>
> - .NET 9
> - Entity Framework Core (SQL Server)
> - Swagger para documentação interativa
> - C# com arquitetura limpa
> - SQL Server (remoto em uma VPS com Docker)
> - ASP.NET Identity para gerenciamento de usuários
> - JWT (JSON Web Token) para autenticação segura
> - Autorização baseada em roles e policies

# Estrutura do Projeto
```bash
API-Funcional/
├─ Configuration/
	ApiConfig.cs       # Configurações de controllers, behaviors, formatação e filtros globais.
	CorsConfig.cs      # Definição das políticas de CORS, origens permitidas e métodos autorizados.
	DbContextConfig.cs # Configuração do Entity Framework, connection string, migrations e tracking.
	IdentityConfig.cs  # Configuração do JWT, autenticação, autorização e políticas de acesso.
	SwaggerConfig.cs   # Documentação da API, versionamento e segurança.
├─ Controllers/        # Onde ficam os endpoints da API
├─ Data/               # Contexto do banco e configuração do EF Core
├─ Migrations/         # Scripts de criação e alterações do banco
├─ Models/             # Classes de domínio e DTOs
├─ appsettings.json    # Configurações da aplicação (não subir senhas)
├─ Program.cs          # Configuração e inicialização da API
```

# Destaques do Projeto

	•	Arquitetura modular: Controllers, Models, Data e Migrations.
	•	Conexão com SQL Server utilizando Entity Framework Core.
	•	CRUD completo com validações e estrutura clara.
	•	Documentação automática via Swagger.
	•	Projeto pensado como template reutilizável para futuras APIs.
	•	Configuração pronta para boas práticas de segurança, sem expor credenciais.
	•	Sistema completo de autenticação com Identity + JWT.
	•	Controle de acesso via autorização (roles, policies e [Authorize]).

# Boas Práticas

	•	Separação clara de responsabilidades (Configuration, Controller, Data, Identity)
	•	Versionamento de banco com Entity Framework Migrations
	•	Endpoints documentados e testáveis via Swagger
	•	Preparado para deploy seguro em ambientes cloud
	•	Uso de .gitignore para não expor credenciais sensíveis
	•	Implementar segurança moderna com Identity + JWT
	•	Program.cs limpo, com inicialização mínima e modular

# Objetivo

Esta API foi criada para:

	•	Consolidar conhecimentos em .NET, EF Core e arquitetura de APIs
	•	Servir como base/template reutilizável
	•	Padronizar boas práticas de organização, segurança e versionamento
	•	Criar uma fundação robusta para futuros projetos, inclusive SaaS

---

## Development

Clone o repositório:

```bash
git clone <URL_DO_REPOSITORIO>
cd API-Funcional
```

Configure a conexão com o banco no appsettings.json ou usando variáveis de ambiente:

```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=API_Funcional;User Id=SEU_USER;Password=SUA_SENHA;"
}

```

Instale as dependências e crie o banco:

```bash
dotnet restore
dotnet ef database update
```

Rode a API:

```bash
dotnet run
```

Acesse a documentação dos endpoints em:

```bash
https://localhost:7200/swagger/index.html
```

---

Copyright © 2025-present [Jhonny Brustolin](https://github.com/jhonnydevbr).
