# API FUNCIONAL .NET


API Funcional é uma API em .NET completa, construída como projeto de aprendizado e também para servir como template reutilizável em futuros projetos. 
Ela implementa uma arquitetura típica de APIs modernas, incluindo Controllers, Models, Data, Migrations e integração com SQL Server.

> [!Tecnologias]
>
> - .NET 9
> - Entity Framework Core (SQL Server)
> - Swagger/OpenAPI para documentação interativa
> - C# com arquitetura limpa
> - SQL Server (remoto em uma VPS com Docker)

> 📂 [!Estrutura do Projeto]
> API-Funcional/
├─ Controllers/       # Onde ficam os endpoints da API
├─ Data/              # Contexto do banco e configuração do EF Core
├─ Migrations/        # Scripts de criação e alterações do banco
├─ Models/            # Classes de domínio e DTOs
├─ appsettings.json   # Configurações da aplicação (não subir senhas)
├─ Program.cs         # Configuração e inicialização da API

⚡ Funcionalidades
	•	Conexão com SQL Server
	•	CRUD completo usando Entity Framework
	•	Suporte a migrations para versionamento do banco
	•	Endpoints documentados com Swagger/OpenAPI
	•	Estrutura modular que facilita criar novas APIs rapidamente

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

📝 Boas Práticas
	•	Não suba credenciais no repositório. Use .gitignore e variáveis de ambiente.
	•	Use migrations para controlar alterações do banco.
	•	Mantenha controllers e models organizados para fácil manutenção.
	•	Este projeto serve como template: basta duplicar e adaptar para novos projetos.

📌 Objetivo

Esta API foi criada para:
	•	Documentar meu aprendizado em .NET e Entity Framework
	•	Servir de base/template para futuras APIs
	•	Demonstrar boas práticas de organização de projeto e versionamento de banco

---

Copyright © 2025-present [Jhonny Brustolin](https://github.com/jhonnydevbr).
