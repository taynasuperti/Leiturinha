# Leiturinha - Sistema de Avaliação e Gerenciamento de Livros  
**ASP.NET Core · Entity Framework · SQL Server**

Sistema web desenvolvido em **ASP.NET Core MVC** para gerenciamento de livros, avaliações, comentários e usuários, com área administrativa e sistema de autenticação.

---

## Funcionalidades

### CRUD Completo de Livros
- **Create** – Cadastro de livros com título, autor, descrição, imagem, gênero e classificação indicativa  
- **Read** – Listagem e visualização de livros com detalhes   
- **Update** – Edição de informações e imagem dos livros  
- **Delete** – Exclusão de livros do sistema

### Recursos Adicionais
- Avaliação de livros com sistema de estrelas  
- Comentários com limite de até 5000 caracteres  
- Cadastro e autenticação de usuários  
- Área administrativa com controle de acesso por perfil  
- Painel de administração com cards
- Visualização de usuários cadastrados com nome, email, username e data de cadastro  
- Upload de imagens de perfil e capas de livros  
- Filtro por gênero literário
---

## Tecnologias Utilizadas

- **ASP.NET Core MVC 8.0** – Framework web principal  
- **Entity Framework Core 8.0** – ORM para acesso ao banco de dados  
- **SQL Server** – Sistema de gerenciamento de banco de dados  
- **Bootstrap 5** – Framework CSS para design responsivo  
- **Authentication Cookies** – Sistema de autenticação baseado em cookies

---

## Pré-requisitos

Antes de começar, certifique-se de ter instalado:

- .NET SDK 8.0 ou superior  
- SQL Server (2019 ou superior) ou SQL Server Express  
- SQL Server Management Studio (SSMS) – opcional  
- Visual Studio 2022 ou VS Code

---

## Instalação e Configuração

### 1. Clone o Repositório

```bash
git clone <url-do-repositorio>
cd Leiturinha
```

### 2. Configure a Connection String
No arquivo **appsettings.json**, ajuste de acordo com seu SQL Server:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=LeiturinhaDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

### Opções de Connection String:

Para SQL Server Express (padrão): 

```bash
Server=localhost\\SQLEXPRESS;Database=LeiturinhaDb;Trusted_Connection=True;TrustServerCertificate=True;
```

Para SQL Server com Windows Authentication: 

```bash
Server=localhost;Database=LeiturinhaDb;Trusted_Connection=True;TrustServerCertificate=True;
```

Para SQL Server com Usuário e Senha: 

```bash
Server=localhost;Database=LeiturinhaDb;User Id=seu_usuario;Password=sua_senha;TrustServerCertificate=True;
```


### Instale as Dependências
```bash
dotnet restore
```

### Instale a Ferramenta EF Core (se ainda não tiver)
```bash
dotnet tool install --global dotnet-ef
```

Ou atualize se já tiver instalado:

```bash
dotnet tool update --global dotnet-ef
```

### Execute as Migrations
Importante: Se você clonou o projeto que anteriormente usava outro banco, remova as migrations antigas primeiro:

```bash
dotnet ef migrations remove
```

### Crie as migrations para SQL Server:

```bash
dotnet ef migrations add InitialCreate
```

Aplique as migrations ao banco de dados:

```bash
dotnet ef database update
```

Este comando irá:

- Criar automaticamente o banco de dados LeiturinhaDb no SQL Server
- Criar todas as tabelas necessárias
- Popular o banco com dados iniciais (um usuário admin padrão)

### Execute a Aplicação

```bash
dotnet run
```
Ou, se estiver usando Visual Studio, pressione F5 para executar em modo debug.

A aplicação estará disponível em:
HTTPS: ```https://localhost:7058```

http: ```//localhost:5001```

(As portas exatas serão exibidas no console ao iniciar)


## Acesso Administrativo


### Credenciais Padrão
O sistema tem automaticamente um usuário administrador:

- Email: ```taynasuperti@gmail.com```
- Senha: ```123456```

IMPORTANTE: Altere essas credenciais após o primeiro acesso em produção!

### Acessar Área Administrativa

1- Acesse a aplicação

2- Clique em "Login" no menu superior

3- Use as credenciais acima

4- Você será redirecionado para o painel administrativo

## Estrutura do Projeto


```
Leiturinha/
│
├── Controllers/
│ ├── AdminController.cs – Administração e visualização de usuários
│ ├── AccountController.cs – Autenticação e registro
│ ├── HomeController.cs – Páginas públicas
│ ├── LivrosController.cs – Visualização e gerenciamento de livros
│ └── AvaliacoesController.cs – Avaliações e comentários
│
├── Models/
│ ├── Livro.cs – Entidade Livro
│ ├── Genero.cs – Gênero literário
│ ├── Avaliacao.cs – Avaliações dos livros
│ ├── Comentario.cs – Comentários dos usuários
│ └── Usuario.cs – Usuário comum e administrador
│
├── Views/
│ ├── Admin/ – Views administrativas
│ ├── Account/ – Views de autenticação
│ ├── Home/ – Views públicas
│ ├── Livros/ – Views de leitura e detalhes
│ ├── Avaliacoes/ – Views de avaliações e comentários
│ └── Shared/ – Layouts e componentes compartilhados
│
├── Data/
│ ├── AppDbContext.cs – Contexto do banco
│ └── DbInitializer.cs – Dados iniciais
│
├── Migrations/ – Migrations do Entity Framework
├── Diagramas/ – Diagramas técnicos do projeto
│ ├── DiagramaClasses.md – Diagrama de classes
│ └── DiagramaCasosUso.md – Diagrama de casos de uso
│
├── wwwroot/ – Arquivos estáticos (CSS, JS, imagens)
│ ├── css/
│ ├── js/
│ ├── lib/
│ └── uploads/ – Uploads de capas e imagens de perfil
│
├── appsettings.json – Configurações da aplicação
├── Program.cs – Ponto de entrada da aplicação
└── README.md – Este arquivo
```

## Estrutura do Banco de Dados
### Tabelas Principais

**Livros**

- Id (PK) 
- Titulo
- Autor
- Sinopse
- ImagemCapa
- GeneroId (FK → Generos)
- DataCadastro
  
**Avaliacoes**

- Id (PK)
- LivroId (FK → Livros)
- UsuarioId (FK → Usuarios)
- Estrelas
- Comentario
- DataAvaliacao

**Comentarios**
  
- Id (PK)
- LivroId (FK → Livros)
- UsuarioId (FK → Usuarios)
- Texto
- DataComentario

**Usuarios**

- Id (PK)
- Nome
- Email
- UserName
- SenhaHash
- DataCadastro
- Foto
- Roles

**Generos**

- Id (PK)
- Nome

## Como Usar

### Criar um Novo Livro

1- Faça login como administrador

2- No painel admin, clique em "Criar Novo Livro"

3- Preencha os campos:
- Título
- Autor
- Descrição
- Imagem de capa (opcional)
- Gênero

4- Clique em "Criar"

### Avaliar um Livro

1- Acesse a página de um livro

2- Selecione a quantidade de estrelas

3- Escreva um comentário (até 5000 caracteres)

4- Clique em "Avaliar"

### Visualizar Usuários Cadastrados

1- Acesse o painel admin

2- Clique em "Usuários Ativos"

3- Veja nome, email, username e data de cadastro

### Editar ou Excluir um Livro

1- No painel admin, localize o livro

2- Clique em "Editar" ou "Excluir"

3- Confirme a ação

## Solução de Problemas

### Erro de Conexão com SQL Server
Problema: A network-related or instance-specific error occurred while establishing a connection to SQL Server

``` bash
Get-Service -Name "MSSQL*"
```

- Verifique se o SQL Server está rodando
- Confirme a connection string no ```appsettings.json```
- Para SQL Server Express, use ```localhost\\SQLEXPRESS```

### Erro ao executar migrations

**Problema:** ```The model for context has pending changes```

**Solução:**

``` bash
dotnet ef migrations remove
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## Metodologia e Arquitetura

Desenvolvido utilizando:

- Metodologia **SCRUM** de desenvolvimento ágil  
- Padrão **MVC (Model-View-Controller)**  
- **Repository Pattern** com Entity Framework Core  
- **Dependency Injection** para gerenciamento de dependências  
- Separação clara de responsabilidades entre camadas  
- Abordagem **Code First** com Entity Framework Core  
- Autenticação baseada em **Claims** e controle de acesso por perfil
