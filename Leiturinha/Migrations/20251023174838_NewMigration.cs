using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Leiturinha.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classificacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaixaEtaria = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classificacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UsuarioLogin_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioRegra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioRegra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioRegra_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioToken",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UsuarioToken_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Capa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destaque = table.Column<bool>(type: "bit", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false),
                    ClassificacaoIndicativaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livros_Classificacoes_ClassificacaoIndicativaId",
                        column: x => x.ClassificacaoIndicativaId,
                        principalTable: "Classificacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Livros_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerfilRegra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilRegra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerfilRegra_Perfil_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioPerfil",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioPerfil", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UsuarioPerfil_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioPerfil_Perfil_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LivroId = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataAvaliacao = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LivroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DataComentario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TextoComentario = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentarios_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImagemLivro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LivroId = table.Column<int>(type: "int", nullable: false),
                    CaminhoImagem = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DescricaoFoto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagemLivro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagemLivro_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01", 0, "5c48095f-0709-47e0-93d5-29c464405cd9", "taynasuperti@gmail.com", true, true, null, "TAYNASUPERTI@GMAIL.COM", "TAYNASUPERTI", "AQAAAAIAAYagAAAAELNpGGq7rnKZV4IB+ut0nmfsXiXIhn8WwC2diGfxadGDXlD9lRPX5ZtG9t0jmCXxFQ==", null, false, "dab09152-36e6-41e5-bd23-70ca9b41ee97", false, "taynasuperti" });

            migrationBuilder.InsertData(
                table: "Classificacoes",
                columns: new[] { "Id", "FaixaEtaria" },
                values: new object[,]
                {
                    { 1, "0–2 anos" },
                    { 2, "3–5 anos" },
                    { 3, "6–7 anos" },
                    { 4, "8–9 anos" },
                    { 5, "10–12 anos" }
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Aventura" },
                    { 2, "Contos" },
                    { 3, "Fábulas" },
                    { 4, "Fantasia" },
                    { 5, "Poesia infantil" }
                });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b44ca04-f6b0-4a8f-a953-1f2330d30894", null, "Administrador", "ADMINISTRADOR" },
                    { "bec71b05-8f3d-4849-88bb-0e8d518d2de8", null, "Funcionário", "FUNCIONÁRIO" },
                    { "ddf093a6-6cb5-4ff7-9a64-83da34aee005", null, "Cliente", "CLIENTE" }
                });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "Id", "Autor", "Capa", "ClassificacaoIndicativaId", "Descricao", "Destaque", "GeneroId", "Titulo" },
                values: new object[,]
                {
                    { 1, "Ziraldo", "~/img/1/o-menino-maluquinho1.jpg", 2, "O Menino Maluquinho é um garoto alegre, criativo e cheio de energia. Com suas travessuras, brincadeiras e versinhos, ele espalha diversão por onde passa e mostra que a verdadeira felicidade está na amizade e no amor.", false, 1, "O Menino Maluquinho" },
                    { 2, "Ziraldo", "~/img/2/maluquinho-de-familia1.jpg", 3, "Ao investigar suas origens para um trabalho escolar sobre a família real do Brasil, o Menino Maluquinho percebe que não sabe nada sobre sua genealogia. Com a ajuda do álbum de fotos antigas do avô, ele embarca numa divertida jornada pelas memórias da família e descobre que a maluquice é uma herança de sangue.", false, 1, "Maluquinho de família" },
                    { 3, "Molly Wigand", "~/img/3/como-ser-amigo1.jpg", 4, "Neste livro, Molly Wigand ensina às crianças os pilares de uma boa amizade — lealdade, verdade e honestidade — e mostra, de forma acessível e carinhosa, como elas podem cultivar relações saudáveis e se tornar ótimos amigos.", true, 5, "Como ser Amigo: um Livro Sobre Amizade" },
                    { 4, "Ana Maria Machado", "~/img/4/o-tesouro-da-raposa1.jpg", 3, "A simpática Raposa revelou a Mico Maneco que tem um tesouro. Curioso, Maneco faz de tudo para descobrir onde se esconde tanta riqueza.", false, 1, "O tesouro da raposa" },
                    { 6, "Emília Nuñez", "~/img/6/a-ursinha-que-nao-dormia-sozinha1.jpg", 2, "A história acompanha Ursita, uma filhotinha que adora dormir na cama dos pais. Com carinho e apoio da família, ela aprende a ter confiança para dormir sozinha em sua própria caminha, descobrindo que sonhos tranquilos também podem acontecer ali.", true, 1, "A ursinha que não queria dormir sozinha" },
                    { 7, "Neil Gaiman", "~/img/7/coraline1.jpg", 5, "Ao se mudar para uma casa antiga com os pais, Coraline descobre uma porta secreta que a leva a um mundo paralelo. Lá, tudo parece perfeito: seus \"outros pais\" são atenciosos e o ambiente é encantador. Mas logo ela percebe que esse universo esconde perigos sombrios, e retornar à sua verdadeira casa será uma jornada assustadora e desafiadora.", true, 1, "Coraline" },
                    { 8, "Joana Bragança", "~/img/8/as-aventuras-de-nino1.jpg", 3, "Nino Aprende a Esperar, Nino e o Som Misterioso e Nino e o Tesouro Esquecido são três histórias ilustradas e encantadoras que acompanham o esquilo Nino enquanto descobre valores importantes como a paciência, a coragem e a honestidade.", false, 1, "As Aventuras do Nino - Volume 1: Nino Aprende a Esperar & Nino e o Som Misterioso & Nino e o Tesouro Esquecido" },
                    { 9, "Ana Maria Machado", "~/img/9/menina-bonita-do-laco-de-fita1.jpg", 4, "Uma linda menina negra desperta a admiração de um coelho branco, que deseja ter uma filha tão pretinha quanto ela. Cada vez que ele lhe pergunta qual o segredo de sua cor, ela inventa uma história.", true, 1, "Menina bonita do laço de fita" },
                    { 10, "Ziraldo", "~/img/10/meu-amigo-canguru1.jpg", 4, "Ziraldo relembra sua infância. Na enciclopédia, entre o A e o F, ele encontrou a figura de um canguru. Foi amor à primeira vista.", true, 1, "Meu Amigo, o Canguru" },
                    { 11, "Janaina Tokitaka", "~/img/12/o-pedido-da-fada-madrinha1.jpg", 3, "A Fada Madrinha está cansada! Hoje é o aniversário dela e ela resolve tirar um dia de folga. O que acontecerá com o reino encantado?", false, 2, "O pedido da Fada Madrinha" },
                    { 12, "Ana Maria Machado", "~/img/14/camilao-o-comilao1.jpg", 3, "Conheça o Camilo, um simpático leitão, amigo de todo mundo, mas um grande comilão!", false, 3, "Camilão, o comilão" },
                    { 13, "Ruth Rocha", "~/img/15/a-primaveira-da-lagarta1.jpg", 4, "Depois de uma reunião debaixo da bananeira da floresta, os bichos decidem caçar a lagarta.", true, 3, "A primavera da lagarta" },
                    { 14, "Antoine de Saint-Exupéry", "~/img/18/o-pequeno-principe1.jpg", 5, "Um piloto encontra um pequeno príncipe que o leva a uma aventura filosófica e poética.", true, 3, "O Pequeno Príncipe" },
                    { 15, "Vários Autores", "~/img/19/o-patinho-feio1.jpg", 3, "O patinho feio é rejeitado por sua família e parte em busca de aceitação.", false, 2, "O Patinho Feio" },
                    { 16, "Christian Hans Andersen", "~/img/20/o-soldadinho-de-chumbo.jpg", 5, "Contos clássicos de Andersen compilados neste volume.", false, 2, "O Soldadinho de Chumbo: e Outros Contos de Andersen" },
                    { 17, "Avelino Guedes", "~/img/22/o-sanduiche-da-maricota.jpg", 3, "A galinha Maricota prepara um sanduíche e a bicharada dá palpites.", true, 3, "O sanduíche da Maricota" },
                    { 18, "Tim Warnes", "~/img/25/perigoso-contem-coelhos1.jpg", 3, "Uma história hilária sobre amizade e rótulos.", true, 3, "Perigoso! Este Livro Contém Coelhos!" },
                    { 19, "Ruth Rocha", "~/img/26/rato-do-campo-e-da-cidade.jpg", 2, "Uma deliciosa fábula sobre diferenças entre campo e cidade.", false, 3, "O rato do campo e o rato da cidade" },
                    { 20, "Ciranda Cultural", "~/img/27/a-raposa-e-as-uvas1.jpg", 3, "Uma história sobre humildade e paciência.", false, 3, "A raposa e as uvas" },
                    { 21, "Tatiana Belinky", "~/img/28/contos-de-muitos-povos.jpg", 4, "Contos populares recontados com leveza e humor.", false, 3, "Contos de Muitos Povos" },
                    { 22, "Pé da Letra", "~/img/29/lobo-e-os-sete-cabritinhos.jpg", 1, "Uma cabra deixa seus sete filhos sozinhos em casa e alerta sobre o Lobo Mau.", false, 3, "O Lobo e os Sete Cabritinhos" },
                    { 23, "Corey Tabor", "~/img/30/simao-e-o-osso1.jpg", 2, "Uma lição sobre empatia em forma de história infantil.", true, 3, "Simão e o osso" },
                    { 24, "Geizy Reis", "~/img/31/o-reino-das-cores.jpg", 2, "Sete reinos, cada um com uma cor; no fim descobrem o valor da união.", true, 4, "O Reino das Cores" },
                    { 25, "Elisa De Biase Hopman", "~/img/32/a-floresta-encantada.jpg", 3, "Várias cenas da floresta descritas com leveza e ilustrações primorosas.", false, 4, "A Floresta Encantada" },
                    { 26, "Emília Nuñez", "~/img/34/chorar-e-como-chover1.jpg", 5, "Uma história para refletir sobre emoções da infância.", true, 4, "Chorar é como Chover" },
                    { 27, "Lewis Carroll", "~/img/40/alice-no-pais-das-maravilhas1.jpg", 5, "Alice segue o Coelho Branco até uma toca e vive aventuras maravilhosas.", true, 4, "Alice no País das Maravilhas (Classic Edition)" },
                    { 28, "Van Macedo", "~/img/47/versos-magicos1.jpg", 4, "Poemas que inspiram a criatividade dos pequenos leitores.", false, 5, "Versos Mágicos" },
                    { 29, "José Paulo Paes", "~/img/48/poemas-para-brincar1.jpg", 2, "Um clássico da poesia infantil brasileira para brincar com a língua.", false, 5, "Poemas para Brincar" },
                    { 30, "Eduardo Rodrigues", "~/img/49/pequenos-poemas.jpg", 3, "Pequenos poemas que convidam à graça das coisas cotidianas.", false, 5, "Pequenos Poemas Para Pequenos" },
                    { 31, "Roseana Murray e Roger Mello", "~/img/50/jardins1.jpg", 5, "Quinze pequenos poemas que representam jardins variados.", false, 5, "Jardins" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataNascimento", "Foto", "Nome" },
                values: new object[] { "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01", new DateTime(2006, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "/img/usuarios/no-photo.png", "Tayná Carolina Miguel Superti" });

            migrationBuilder.InsertData(
                table: "UsuarioPerfil",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0b44ca04-f6b0-4a8f-a953-1f2330d30894", "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01" },
                    { "bec71b05-8f3d-4849-88bb-0e8d518d2de8", "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01" },
                    { "ddf093a6-6cb5-4ff7-9a64-83da34aee005", "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01" }
                });

            migrationBuilder.InsertData(
                table: "ImagemLivro",
                columns: new[] { "Id", "CaminhoImagem", "DescricaoFoto", "LivroId" },
                values: new object[,]
                {
                    { 1, "~/img/1/o-menino-maluquinho2.jpg", "Foto adicional", 1 },
                    { 2, "~/img/2/maluquinho-de-familia2.jpg", "Foto adicional", 2 },
                    { 3, "~/img/3/como-ser-amigo2.jpg", "Foto adicional", 3 },
                    { 4, "~/img/6/a-ursinha-que-nao-dormia-sozinha2.jpg", "Foto adicional", 6 },
                    { 5, "~/img/6/a-ursinha-que-nao-dormia-sozinha3.jpg", "Foto adicional", 6 },
                    { 6, "~/img/7/coraline2.jpg", "Foto adicional", 7 },
                    { 7, "~/img/7/coraline3.jpg", "Foto adicional", 7 },
                    { 8, "~/img/8/as-aventuras-de-nino2.jpg", "Foto adicional", 8 },
                    { 9, "~/img/9/menina-bonita-do-laco-de-fita2.jpg", "Foto adicional", 9 },
                    { 10, "~/img/9/menina-bonita-do-laco-de-fita3.jpg", "Foto adicional", 9 },
                    { 11, "~/img/9/menina-bonita-do-laco-de-fita4.jpg", "Foto adicional", 9 },
                    { 12, "~/img/12/o-pedido-da-fada-madrinha2.jpg", "Foto adicional", 11 },
                    { 13, "~/img/12/o-pedido-da-fada-madrinha3.jpg", "Foto adicional", 11 },
                    { 14, "~/img/12/o-pedido-da-fada-madrinha4.jpg", "Foto adicional", 11 },
                    { 15, "~/img/30/simao-e-o-osso3.jpg", "Foto adicional", 23 },
                    { 16, "~/img/34/chorar-e-como-chover2.jpg", "Foto adicional", 26 },
                    { 17, "~/img/34/chorar-e-como-chover3.jpg", "Foto adicional", 26 },
                    { 18, "~/img/34/chorar-e-como-chover4.jpg", "Foto adicional", 26 },
                    { 19, "~/img/40/alice-no-pais-das-maravilhas2.jpg", "Foto adicional", 27 },
                    { 20, "~/img/40/alice-no-pais-das-maravilhas3.jpg", "Foto adicional", 27 },
                    { 21, "~/img/40/alice-no-pais-das-maravilhas4.jpg", "Foto adicional", 27 },
                    { 22, "~/img/47/versos-magicos2.jpg", "Foto adicional", 28 }
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_LivroId",
                table: "Avaliacoes",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_LivroId",
                table: "Comentarios",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_UsuarioId",
                table: "Comentarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagemLivro_LivroId",
                table: "ImagemLivro",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_ClassificacaoIndicativaId",
                table: "Livros",
                column: "ClassificacaoIndicativaId");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_GeneroId",
                table: "Livros",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Perfil",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilRegra_RoleId",
                table: "PerfilRegra",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLogin_UserId",
                table: "UsuarioLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPerfil_RoleId",
                table: "UsuarioPerfil",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRegra_UserId",
                table: "UsuarioRegra",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "ImagemLivro");

            migrationBuilder.DropTable(
                name: "PerfilRegra");

            migrationBuilder.DropTable(
                name: "UsuarioLogin");

            migrationBuilder.DropTable(
                name: "UsuarioPerfil");

            migrationBuilder.DropTable(
                name: "UsuarioRegra");

            migrationBuilder.DropTable(
                name: "UsuarioToken");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Classificacoes");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
