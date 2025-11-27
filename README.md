# API FUNCIONAL .NET


API Funcional é uma API em .NET completa, construída como projeto de aprendizado e também para servir como template reutilizável em futuros projetos. 
Ela implementa uma arquitetura típica de APIs modernas, incluindo Controllers, Models, Data, Migrations e integração com SQL Server.

# Tecnologias
>
> - .NET 9
> - Entity Framework Core (SQL Server)
> - Swagger/OpenAPI para documentação interativa
> - C# com arquitetura limpa
> - SQL Server (remoto em uma VPS com Docker)

# Estrutura do Projeto
```bash
API-Funcional/
├─ Controllers/       # Onde ficam os endpoints da API
├─ Data/              # Contexto do banco e configuração do EF Core
├─ Migrations/        # Scripts de criação e alterações do banco
├─ Models/            # Classes de domínio e DTOs
├─ appsettings.json   # Configurações da aplicação (não subir senhas)
├─ Program.cs         # Configuração e inicialização da API
```

# Destaques do Projeto

• Arquitetura modular: Controllers, Models, Data e Migrations.
• Conexão com SQL Server utilizando Entity Framework Core.
• CRUD completo com validações e estrutura clara.
• Documentação automática via Swagger/OpenAPI.
• Projeto pensado como template reutilizável para futuras APIs.
• Configuração pronta para boas práticas de segurança, sem expor credenciais.

# Boas Práticas

	•	Separação clara de responsabilidades (Controller, Service, Data)
	•	Versionamento de banco com Entity Framework Migrations
	•	Endpoints documentados e testáveis via Swagger
	•	Preparado para deploy seguro em ambientes cloud
	•	Uso de .gitignore para não expor credenciais sensíveis

# Objetivo

Esta API foi criada para:

	•	Documentar aprendizado em .NET e Entity Framework
	•	Servir de base/template para futuras APIs
	•	Demonstrar boas práticas de organização de projeto e versionamento de banco.

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
https://localhost:5001/swagger
```

---

Copyright © 2025-present [Jhonny Brustolin](https://github.com/jhonnydevbr).
