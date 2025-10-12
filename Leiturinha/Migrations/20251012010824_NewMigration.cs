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
                    table.PrimaryKey("PK_Usuario", x => x.Id);
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
                name: "PerfilRegras",
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
                    table.PrimaryKey("PK_PerfilRegras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerfilRegras_Perfil_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Perfil",
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
                        name: "FK_UsuarioLogin_Usuario_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuario",
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
                        name: "FK_UsuarioPerfil_Perfil_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioPerfil_Usuario_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioRegras",
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
                    table.PrimaryKey("PK_UsuarioRegras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioRegras_Usuario_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuario",
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
                        name: "FK_UsuarioToken_Usuario_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuario",
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
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Conteudo = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
                    DataComentario = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
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
                table: "Livros",
                columns: new[] { "Id", "Autor", "Capa", "ClassificacaoIndicativaId", "Descricao", "Destaque", "GeneroId", "Titulo" },
                values: new object[,]
                {
                    { 1, "Ziraldo", "~/img/1/o-menino-maluquinho1.jpg", 2, "O Menino Maluquinho é um garoto alegre, criativo e cheio de energia. Com suas travessuras, brincadeiras e versinhos, ele espalha diversão por onde passa e mostra que a verdadeira felicidade está na amizade e no amor.", false, 1, "O Menino Maluquinho" },
                    { 2, "Ziraldo", "~/img/2/maluquinho-de-familia1.jpg", 3, "Ao investigar suas origens para um trabalho escolar sobre a família real do Brasil, o Menino Maluquinho percebe que não sabe nada sobre sua genealogia. Com a ajuda do álbum de fotos antigas do avô, ele embarca numa divertida jornada pelas memórias da família e descobre que a maluquice é uma herança de sangue.", false, 1, "Maluquinho de família" },
                    { 3, "Molly Wigand", "~/img/3/como-ser-amigo1.jpg", 4, "Neste livro, Molly Wigand ensina às crianças os pilares de uma boa amizade — lealdade, verdade e honestidade — e mostra, de forma acessível e carinhosa, como elas podem cultivar relações saudáveis e se tornar ótimos amigos.", false, 5, "Como ser Amigo: um Livro Sobre Amizade" },
                    { 4, "Ana Maria Machado", "~/img/4/o-tesouro-da-raposa1.jpg", 3, "A simpática Raposa revelou a Mico Maneco que tem um tesouro. Curioso, Maneco faz de tudo para descobrir onde se esconde tanta riqueza.", false, 1, "O tesouro da raposa" },
                    { 5, "Tatiana Belinky", "~/img/5/a-cesta-da-dona-maricota1.jpg", 3, "Por meio de versos e rimas divertidas, os alimentos da cesta de Dona Maricota ganham vida e destacam os benefícios de uma alimentação saudável com frutas, verduras e legumes. Ideal para crianças do 1º e 2º ano do Ensino Fundamental, o livro promove o aprendizado interdisciplinar com foco em Ciências da Natureza.", false, 1, "A cesta de dona Maricota" },
                    { 6, "Emília Nuñez", "~/img/6/a-ursinha-que-nao-dormia-sozinha1.jpg", 2, "A história acompanha Ursita, uma filhotinha que adora dormir na cama dos pais. Com carinho e apoio da família, ela aprende a ter confiança para dormir sozinha em sua própria caminha, descobrindo que sonhos tranquilos também podem acontecer ali.", false, 1, "A ursinha que não queria dormir sozinha" },
                    { 7, " Neil Gaiman", "~/img/7/coraline1.jpg", 5, "Ao se mudar para uma casa antiga com os pais, Coraline descobre uma porta secreta que a leva a um mundo paralelo. Lá, tudo parece perfeito: seus \"outros pais\" são atenciosos e o ambiente é encantador. Mas logo ela percebe que esse universo esconde perigos sombrios, e retornar à sua verdadeira casa será uma jornada assustadora e desafiadora.", false, 1, "Coraline" },
                    { 8, "Joana Bragança ", "~/img/8/as-aventuras-de-nino1.jpg", 3, "Nino Aprende a Esperar, Nino e o Som Misterioso e Nino e o Tesouro Esquecido são três histórias ilustradas e encantadoras que acompanham o esquilo Nino enquanto descobre valores importantes como a paciência, a coragem e a honestidade.\r\nIdeal para crianças dos 3 aos 7 anos, este livro incentiva o diálogo sobre emoções e atitudes positivas, num universo mágico, colorido e cheio de ternura.", false, 1, "As Aventuras do Nino - Volume 1: Nino Aprende a Esperar & Nino e o Som Misterioso & Nino e o Tesouro Esquecido" },
                    { 9, "Ana Maria Machado", "~/img/9/menina-bonita-do-laco-de-fita1.jpg", 4, "Uma linda menina negra desperta a admiração de um coelho branco, que deseja ter uma filha tão pretinha quanto ela. Cada vez que ele lhe pergunta qual o segredo de sua cor, ela inventa uma história. O coelho segue todos os “conselhos” da menina, mas continua branco. Esta narrativa delicada e tocante aborda temas como autoaceitação, respeito às diferenças e a beleza da diversidade. Com ilustrações encantadoras e uma mensagem poderosa, o livro convida os leitores a refletir sobre a importância de valorizar a singularidade de cada pessoa, independentemente de sua cor de pele.", false, 1, "Menina bonita do laço de fita" },
                    { 10, "Ziraldo", "~/img/10/meu-amigo-canguru1.jpg", 4, "Ziraldo relembra sua infância. Na enciclopédia, entre o A e o F, ele encontrou a figura de um canguru. Foi amor à primeira vista. Gugu foi seu amigo de infância, de sonhos e fantasias, de ternura e aconchego. Ziraldo cresceu, tornou-se escritor, desenhista, artista, e o canguru, sempre à vista.", false, 1, "Meu Amigo, o Canguru" },
                    { 11, "Ana Maria Machado", "~/img/11/branca-de-neve.jpg", 2, "Os mais clássicos contos de fadas em formato diferente para as crianças se divertirem com a historinha ao mesmo tempo que brincam com um quebracabeça à cada página.", false, 2, "Branca de Neve e os Sete Anões | Livro Quebra-Cabeça" },
                    { 12, "Janaina Tokitaka", "~/img/12/o-pedido-da-fada-madrinha1.jpg", 3, "A Fada Madrinha está cansada! Afinal, ela trabalha sem parar para atender a todos os pedidos das princesas dos contos de fadas. Mas hoje é uma data especial: é o aniversário da Fada Madrinha! E se ela resolvesse tirar um merecido dia de folga? O que será que aconteceria com o reino encantado?\r\nEsta nova versão da Fada Madrinha apresentada nesta história da coleção Canoa vai mudar a relação que temos com a já tão conhecida personagem de tantos contos de fadas. Escrito por Janaina Tokitaka e ricamente ilustrado por Flávia Borges, este livro vai surpreender, fazer pensar e arrancar risadas de crianças e adultos. A coleção Canoa tem como objetivo levar literatura infantil de qualidade a um preço popular para todos os pequenos leitores.", false, 2, "O pedido da Fada Madrinha" },
                    { 13, "Susie Brooks", "~/img/13/chapeuzinho-vermelho1.jpg", 1, "Muito contente, CHAPEUZINHO VERMELHO foi vistar a vovozinha, mas não imaginava que o LOBO MAU estava no lugar da velhinha!", false, 2, "Chapeuzinho Vermelho" },
                    { 14, "Ana Maria Machado", "~/img/14/camilao-o-comilao1.jpg", 3, "Conheça o Camilo, um simpático leitão, amigo de todo mundo, mas um grande comilão! Gosta de comer bem, mas nem tanto de trabalhar. Por isso tudo o que come, ele prefere ganhar. Preguiçoso, sem dúvida, mas tem um bom coração. É impossível não amar nosso amigo Camilão!", false, 3, "Camilão, o comilão" },
                    { 15, "Ruth Rocha", "~/img/15/a-primaveira-da-lagarta1.jpg", 4, "Depois de uma reunião debaixo da bananeira da floresta, a formiga, o louva-a-deus, o camaleão (que vivia mudando de opinião), a joaninha, a lagartixa, a libélula, o gafanhoto, o caracol, a aranha e a cigarra (ufa, quanta gente!, ou melhor, quanto bicho!), decidiram caçar a lagarta, porque ela comia folhas demais (como se eles não comessem nada...). Além disso, eles achavam a lagarta muito feia (como se eles fossem muito lindos...). Porém, a caçada aconteceu no início da primavera, quando as lagartas se transformam em... Bem, é melhor não contar o final da história, que ficou ainda mais bonita com os desenhos da Madalena Elek.", false, 3, "A primavera da lagarta" },
                    { 16, "Igor Barbosa ", "~/img/16/joao-e-o-pe-de-feijao1.jpg", 3, "João mora com sua mãe numa cidade chamada Vila Feliz. Mas como são tempos difíceis, o menino decide trocar a vaca leiteira da família por cinco feijões mágicos que um senhor misterioso ofereceu. Mal sabia ele que aquelas sementes o levariam a uma grande aventura, com o poder de transformar sua vida e o futuro de toda a cidade.", false, 2, "João e o Pé de Feijão" },
                    { 17, "Tulip Books", "~/img/17/os-tres-porquinhos1.jpg", 2, "Dê vida à magia dos contos de fadas para os seus filhos. As histórias atemporais e ilustrações encantadoras nestes livros pop-up logo se tornarão a diversão favorita de todos na hora de dormir e ajudarão seus filhos a cair em um sono mágico e tranquilo.  ", false, 2, "Os Três Porquinhos" },
                    { 18, "Antoine de Saint-Exupéry", "~/img/18/o-pequeno-principe1.jpg", 5, "Nesta história que marcou gerações de leitores em todo o mundo, um piloto cai com seu avião no deserto do Saara e encontra um pequeno príncipe, que o leva a uma aventura filosófica e poética através de planetas que encerram a solidão humana.\r\n\r\nUm livro para todos os públicos, O pequeno príncipe é uma obra atemporal, com metáforas pertinentes e aprendizados sobre afeto, sonhos, esperança e tudo aquilo que é invisível aos olhos. ", false, 3, "O Pequeno Príncipe" },
                    { 19, " Vários Autores", "~/img/19/o-patinho-feio1.jpg", 3, "O patinho feio é rejeitado por sua família e decide procurar alguém que o aceite como ele é. Leia esta encantadora história e cole os adesivos para completar as cenas.", false, 2, "O Patinho Feio" },
                    { 20, "Christian Hans Andersen ", "~/img/20/o-soldadinho-de-chumbo.jpg", 5, "O Soldadinho de Chumbo A Menina dos Fósforos O Pequeno Tuque As Flores de Idinha A Camponesa e o Limpador de Chaminés As Cegonhas João Grande e João Pequeno O Pinheirinho O Rouxinol.", false, 2, "O Soldadinho de Chumbo: e Outros Contos de Andersen" },
                    { 21, " Ciranda Cultural", "~/img/21/a-cigarra-e-a-formiga1.jpg", 2, "A cigarra passava os dias cantando, despreocupadamente, enquanto a formiga trabalhava sem parar. O inverno chegará... quem estará mais preparada para enfrentar essa estação? Acompanhe a história e descubra a importância da solidariedade e da amizade verdadeira.", false, 3, "A Cigarra e a Formiga" },
                    { 22, "Avelino Guedes", "~/img/22/o-sanduiche-da-maricota.jpg", 3, "A galinha Maricota preparou um sanduíche. Mas, antes de conseguir comer, a bicharada toda começou a chegar e dar palpite para tornar o sanduíche da Maricota mais gostoso (para eles, é claro). O resultado é difícil de explicar. Só mesmo vendo. Vamos ver?", false, 3, "O sanduíche da Maricota" },
                    { 23, " Ruth Rocha", "~/img/23/a-lebre-e-a-tartaruga1.jpg", 2, "Nesta releitura encantadora, a consagrada Ruth Rocha transforma a clássica fábula sobre a corrida entre a lebre e a tartaruga em uma experiência literária única, em que cada verso e cada rima convidam os leitores a refletirem sobre os valores da perseverança e da humildade.  A lebre e a tartaruga é o quarto livro da coleção Recontos Bonitinhos. Nesta série, Ruth Rocha empresta seu olhar e talento únicos para criar poemas e apresentar histórias clássicas para as novas gerações de pequenos leitores.  Na narrativa, que se inicia com um gostoso convite a adentrar o mundo de imaginação - \"Era uma vez uma lebre, que se achava a tal! Um dia, ela desafiou a tranquila tartaruga para uma corrida sensacional. Quem será que chegou primeiro, afinal?\" - a autora usa a cadência dos versos para dar voz a personagens que, apesar de suas diferenças, ensinam que a jornada da vida pode ser recontada de diversas formas. Abordagem que estimula a criatividade e a sensibilidade, transformando a simples corrida em uma metáfora para os desafios e triunfos cotidianos.  Complementando a narrativa, as ilustrações vibrantes e coloridas de Caco Galhardo dão vida aos personagens e cenários, reforçando o caráter lúdico e inspirador da obra. Cada traço e cor colaboram para que o imaginário infantil se expanda, proporcionando uma experiência visual que dialoga perfeitamente com o texto poético.", false, 3, "A Lebre e a Tartaruga" },
                    { 24, "Ruth Rocha", "~/img/24/fabulas-de-escopo1.jpg", 3, "Se de fato existiu (há quem duvide), Esopo foi um grego do século VI a.C. Como se lê num texto ao final deste livrinho, suas fábulas “são pequenas histórias de caráter moral e alegórico, nas quais os principais personagens são representados por animais que pensam e falam como humanos. Ao fazer isso, Esopo queria mostrar como o ser humano pode agir em determinadas situações”.Essas pequenas histórias foram transmitidas ao longo dos séculos, num boca a boca que durou aproximadamente dois mil anos, até que autores como o francês Jean de La Fontaine, que viveu no século XVII, decidiram colocá-las no papel. Agora é a vez da Ruth Rocha, que escolheu algumas das mais interessantes, como “A raposa e as uvas”, “A cigarra e a formiga” e “A rã e o touro”, e a elas emprestou sua voz única, graciosa, especial.\r\n", false, 3, "Fábulas de Esopo" },
                    { 25, "Tim Warnes", "~/img/25/perigoso-contem-coelhos1.jpg", 3, "O melhor amigo do Bob,uma coisa escamosa,encontrou um chapéu.Havia uma etiqueta nele que dizia:PERIGO! NÃO TOQUE! Tire isso! gritou Bob. Pode ser perigoso!Então, de dentro da cartola saltou um coelho.E depois outro! E outro!Mas os coelhos não são perigosos. São?Uma história hilária sobre amizade.E rótulos...", false, 3, "Perigoso! Este Livro Contém Coelhos!" },
                    { 26, "Ruth Rocha", "~/img/26/rato-do-campo-e-da-cidade.jpg", 2, "Era uma vez uma família de ratos que morava no campo. “Viviam perto de um celeiro, cheinho de grãos, de maneira que sempre tinham o que comer”, nos conta a Ruth Rocha. Um dia eles receberam a visita de um primo da cidade, Jôni Raturbano, que era grã-fino e, sem querer querendo, sempre dava um jeito de criticar a vida rural. Dizia que na cidade é que era bom. Quando chegou a hora de ir embora, Jôni Raturbano convidou seu primo Rateco para ir com ele. Rateco gostou da ideia. Mas será que a cidade grande trataria bem do nosso ratinho?Da série Conta de Novo, O rato do campo e o rato da cidade é uma deliciosa fábula (atribuída a Esopo) sobre as diferenças entre o campo e a cidade, mas também uma defesa sem concessões à dignidade dos homens, ops, quero dizer, dos ratos.", false, 3, "O rato do campo e o rato da cidade" },
                    { 27, "Ciranda Cultural", "~/img/27/a-raposa-e-as-uvas1.jpg", 3, "Uma raposa estava andando pela floresta e com vontade de comer algo doce. Ela se deparou com uma parreira cheinha de belas uvas, mas não conseguia pegá-las. Leia esta história que fala sobre humildade e paciência.", false, 3, "A raposa e as uvas" },
                    { 28, "Tatiana Belinky", "~/img/28/contos-de-muitos-povos.jpg", 4, "As histórias populares são transmitidas de geração em geração e trazem as questões mais humanas, a sabedoria tradicional e as marcas culturais de diferentes povos. É o que se revela nesta obra por meio de contos de diversos lugares do mundo, recontados pela escrita leve, fluida e bem-humorada de Tatiana Belinky.", false, 3, "Contos de Muitos Povos" },
                    { 29, "Pé da Letra", "~/img/29/lobo-e-os-sete-cabritinhos.jpg", 1, "Uma cabra deixou seus sete filhos sozinhos em casa enquanto procura comida na floresta. Antes de sair, ela alertou sobre o Lobo Mau, que irá tentar entrar na casa.", false, 3, "O Lobo e os Sete Cabritinhos" },
                    { 30, "Corey Tabor", "~/img/30/simao-e-o-osso1.jpg", 2, "Passeando ao redor do lago com seu osso, Simão avista outro cão com um osso melhor e propõe um desafio: quem fizer os truques mais legais, fica com o osso.\r\n\r\nMas ao perceber que o cachorro sabe fazer as mesmas acrobacias que ele, Simão acaba recebendo algo muito melhor do que aquilo que queria: uma lição sobre empatia.\r\n\r\nDo autor vencedor da Medalha Caldecott Corey Tabor, Simão e o osso é uma leitura que vai entreter enquanto ensina sobre generosidade e amizade.", false, 3, "Simão e o osso" },
                    { 31, " Geizy Reis", "~/img/31/o-reino-das-cores.jpg", 2, "E se o mundo fosse todo de uma só cor? Teria a mesma graça e esplendor? O reino das cores é uma história que fala exatamente sobre isso. O livro conta a história de sete reinos, cada um com uma única cor. Porém as cores entram numa disputa para mostrar qual era a mais bonita e importante. No fim, elas descobrem que isso não é o principal e que juntas poderiam criar algo encantador. O enredo tem o intuito de abordar o respeito às diferenças, o diálogo, a união. Conta com uma narrativa simples, na qual cores são usadas para representar as pessoas e seus mundos, além de abordar as cores de forma lúdica e atrativa.", false, 4, "O Reino das Cores" },
                    { 32, "Elisa De Biase Hopman", "~/img/32/a-floresta-encantada.jpg", 3, "Na Floresta Encantada, diferentes animais vivem a sua rotina. A cigarra, o passarinho, o porco-espinho, a formiga, o beija-flor, o macaco, o besouro, o tucano, o pica-pau, a centopeia, as abelhas... e a floresta dá lugar a estas cenas, descritas com leveza pela fonoaudióloga Elisa De Biase Hopman e ilustradas com primor pelo artista Tiago Costa, favorecendo a imaginação e o encanto do pequeno leitor.", false, 4, "A Floresta Encantada" },
                    { 33, "Ruth Stiles Gannett", "~/img/33/dragoes-de-terrazul1.jpg", 4, "Depois de deixar Elmer em Nuncaverde, o bebê dragão parte em direção a Terrazul, o refúgio dos últimos dragões, ansioso pelo reencontro com sua família. Ao sobrevoar o Deserto Terrível, porém, ele percebe, alarmado, que homens descobriram a região e estão capturando dragões para vendê-los ao zoológico. Mais do que nunca, o bebê dragão precisará da ajuda de seu amigo Elmer para resgatar sua família e salvar Terrazul.\r\n\r\nOs dragões de Terrazul é o último livro da trilogia iniciada com O dragão do meu pai e Elmer o dragão. Com uma combinação perfeita de capítulos curtos e ação constante, a história é ideal para crianças que estão ganhando fluência em leitura e que buscam histórias com textos um pouco mais longos, sem abrir mão de uma leitura leve e prazerosa. É também uma escolha certeira para pais que desejam oferecer aos filhos uma aventura inesquecível para ser lida em voz alta ― do tipo que cativa a atenção de tal maneira que é impossível parar antes da última página.", false, 4, "Os dragões de Terrazul" },
                    { 34, "Emília Nuñez", "~/img/34/chorar-e-como-chover1.jpg", 5, "Com ilustrações poéticas e texto emocionante, Chorar é como Chover é uma história para refletir sobre as emoções da infância e a importância de abraçar o que se sente.", false, 4, "Chorar é como Chover" },
                    { 35, " Chris Saunders e Emília Nuñez", "~/img/35/acreditar1.jpg", 4, "Um livro para sua criança descobrir o que a torna especial! Preguiça vive uma emocionante jornada de autodescoberta enquanto dá o seu melhor para entender o que o faz único. Com a ajuda de seus amigos, ele descobre que a resposta estava dentro dele otempo todo!", false, 4, "Acreditar" },
                    { 36, "Fiona Watt", "~/img/36/fadas-do-jardim.jpg", 2, "Este livro de adesivos está repleto de fadas para vestir e cenas de um lindo jardim para decorar e vivenciar aventuras divertidas. Com mais de 200 adesivos de roupas, animais e flores para completar as cenas, as crianças vão passar momentos deliciosos decorando o mundo das fadas.", false, 4, "A Fada do Jardim" },
                    { 37, " Emília Nuñez", "~/img/37/zumbi-net1.jpg", 3, "Existe uma lenda urbana que conta de um mundo paralelo no qual as crianças vão parar de tanto exagerar nos games. É o Zumbi.net! Quando Juca encontra Gael congelado na tela do videogame, não tem dúvidas: ele e a sua irmã Cecília vão ter que dar um jeito de entrar no Zumbi.net para resgatar o amigo!", false, 3, "Zumbi.net" },
                    { 38, " Silvana Rando", "~/img/38/gildo1.jpg", 3, "Gildo é muito corajoso. Ele gosta de montanha-russa, de avião, de filme de terror e de cantar em público. Mas como quase todo mundo, existe uma coisa que o deixa apavorado... Sempre na noite anterior a alguma festinha de aniversário de um amigo, ele não consegue pregar os olhos, por que será?", false, 4, "Gildo" },
                    { 39, "Isa Colli", "~/img/39/o-reino-do-tempo1.jpg", 5, "Em uma terra distante, os monarcas Solaris e Selíní viviam em harmonia com a natureza, regendo as estações do ano. Com o passar do tempo, porém, eles perceberam que precisavam de ajuda. Quatro crianças mágicas foram, então, preparadas pelo rei e pela rainha para assumir a tarefa de espalhar seus encantos por toda a parte. Desde aqueles dias longínquos, Primavera, Verão, Outono e Inverno, têm a missão de manter o equilíbrio entre si, garantindo a continuidade dessa missão vital para todos os seres do Reino. Cores de pôr-do-sol, cristais brancos e alegrias de fim de tarde aguardam os súditos nessa saga perfumada à natureza.", false, 4, "O Reino do Tempo" },
                    { 40, "Lewis Carroll", "~/img/40/alice-no-pais-das-maravilhas1.jpg", 5, "Uma menina, um coelho e uma história capazes de fazer qualquer um de nós voltar a sonhar. Alice é despertada de um leve sono ao pé de uma árvore por um coelho peculiar. Uma criatura alva e falante com roupas engraçadas, que consulta seu relógio e reclama do próprio atraso. Curiosa como toda criança, Alice segue o animal até cair em um buraco sem fim que mudou para sempre a literatura infantil. Mais de 150 anos depois, Alice no País das Maravilhas continua repleto de ensinamentos para aqueles que ousaram seguir o Coelho Branco até sua toca.", false, 4, "Alice no País das Maravilhas (Classic Edition)" },
                    { 41, "Vinícius de Moraes", "~/img/41/a-arca-de-noe1.jpg", 2, "Crianças e adultos sabem de cor alguns dos poemas infantis de Vinicius de Moraes, graças ao ritmo inteligente e bem-humorado dos seus versos. As deliciosas versões musicais de A arca de Noé são exemplo dessa simpatia que o poeta conquistou entre pequenos e grandes leitores. Os discos A arca de Noé 1 (1980) e A arca de Noé 2 (1981) traziam composições como \"O pato\", \"A casa\", \"O gato\", \"O pingüim\" e \"São Francisco\", que se tornaram famosas nas vozes de Chico Buarque, Milton Nascimento, Toquinho, Marina Lima e Ney Matogrosso, entre outros intérpretes. Agora o livro A arca de Noé ganha nova edição, com todos os 32 poemas da edição original, publicada pela Companhia das Letrinhas pela primeira vez em 1993. Ilustrações assinadas por Nelson Cruz compõem a reedição deste clássico infantil. O poeta Vinicius de Moraes (1913-1980) teve um verdadeiro caso de amor com a música brasileira, tornando-se um de seus maiores letristas. A lista de seus parceiros musicais é vasta e inclui Tom Jobim, Baden Powell, Chico Buarque, Carlos Lyra, Edu Lobo e Toquinho, entre outros.", false, 5, "A Arca de Noé" },
                    { 42, " Micheliny Verunschk", "~/img/42/som-do-rugido-da-onca1.jpg", 5, "Em 1817, Spix e Martius desembarcaram no Brasil com a missão de registrar suas impressões sobre o país. Três anos e 10 mil quilômetros depois, os exploradores voltaram a Munique trazendo consigo não apenas um extenso relato da viagem, mas também um menino e uma menina indígenas, que morreriam pouco tempo depois de chegar em solo europeu.\r\nEm seu quinto romance, Micheliny Verunschk constrói uma poderosa narrativa que deixa de lado a historiografia hegemônica para dar protagonismo às crianças ― batizadas aqui de Iñe-e e Juri ― arrancadas de sua terra natal. Entrelaçando a trama do século XIX ao Brasil contemporâneo, somos apresentados também a Josefa, jovem que reconhece as lacunas de seu passado ao ver a imagem de Iñe-e em uma exposição.\r\nCom uma prosa embebida de lirismo, este é um livro sem paralelos na literatura brasileira ao tratar de temas como memória, colonialismo e pertencimento.\r\n\r\n“Um romance que expande as fronteiras da arte literária ao trazer memória, argumentos antropológicos e o melhor que a ficção pode nos oferecer.” ― Itamar Vieira Junior", false, 5, "O som do rugido da onça – Vencedor Jabuti 2022" },
                    { 43, "James Misse e Pé Da Letra", "~/img/43/cantigas-de-roda1.jpg", 2, "O autor, músico e arte educador james misse, traz neste trabalho um resgate das cantigas de roda como manifestação cultural, desenvolvendo assim a consciência corporal, repertório musical, coordenação motora, socialização e inclusão. Em outras palavras, as cantigas de roda representam uma grande brincadeira com vivencias e descobertas que se transformam em experienciais reais. Esse trabalho conta com as incríveis ilustrações de laura almeida.", false, 5, "Cantigas de Roda" },
                    { 44, "Ana Maria Machado", "~/img/44/mas-que-festa1.jpg", 3, "Os convites começam a circular: Manuel avisa Frederico, Giovani fala com Beto, Maíra chama Toshiro... De casa em casa, de família em família, a festa de aniversário vai crescendo e ganhando cores, sabores e sotaques.\r\n\r\nNo dia da festa, cada criança chega trazendo um prato preparado em casa e logo a mesa transborda de delícias: cajuzinhos, quibes, pizzas, bolinhos de bacalhau, paellas, pastéis, feijoadas, vatapás, macarronadas e estrogonofes. É fartura garantida!\r\n\r\nNesse clima animado, Ana Maria Machado celebra a diversidade do povo brasileiro. Descendentes de indígenas, africanos, europeus e asiáticos se encontram em uma festa inesquecível, com futebol, música, comilança e muita diversão.", false, 5, "Mas que festa!: Nova edição " },
                    { 45, "Tatiana Belinky", "~/img/45/o-caso-dos-ovos1.jpg", 4, "As galinhas estão em greve: não botam mais ovo! Mas a Páscoa vem chegando, e a produção não pode parar...", false, 5, "O caso dos ovos" },
                    { 46, "Leo Cunha", "~/img/46/catigamente1.jpg", 3, "Os poemas de Leo Cunha refletem o mundo das crianças e desenvolvem nelas o gosto pela palavra. Os assuntos desses poemas foram retirados do universo infantil, com um olhar sensível e encantador.", false, 5, "Cantigamente" },
                    { 47, "Van Macedo", "~/img/47/versos-magicos1.jpg", 4, "No livro \"Versos Mágicos: Livro de Poemas\", cada página é uma aventura poética, onde palavras dançam em harmonia com ilustrações vibrantes. Viaje por paisagens poéticas que inspirarão a criatividade dos pequenos leitores, enquanto personagens cativantes ganham vida através das páginas. Com rimas suaves e ilustrações envolventes, este livro é uma janela para a poesia que encanta corações e estimula mentes curiosas. Prepare-se para uma viagem poética cheia de diversão e aprendizado!", false, 5, "Versos Mágicos" },
                    { 48, "José Paulo Paes", "~/img/48/poemas-para-brincar1.jpg", 2, "Um clássico da poesia infantil brasileira em que José Paulo Paes propõe a seus leitores brincar com a língua portuguesa. Os poemas apresentam jogos de palavras e até um abecedário com significados inusitados, que diverte, instiga a criatividade das crianças e ainda faz pensar.", false, 5, "Poemas para Brincar" },
                    { 49, "Eduardo Rodrigues", "~/img/49/pequenos-poemas.jpg", 3, "A natureza, os livros, o tempo, a fome, o medo: tudo é visto com poesia e se transforma em poemas sob o olhar inventivo de Eduardo Rodrigues. Os pequenos poemas, independentes entre si e harmônicos no conjunto que formam, convidam os leitores (não só os pequenos) à graça que as coisas cotidianas têm ou podem ter, se deslocadas da maneira comum como as conhecemos. As ilustrações de Maria Valentina ampliam essa ideia de primeira vez que experimentamos na fruição artística, oferecendo nas poéticas e divertidas criações visuais mais ritmos e melodias para a leitura, a declamação e a escuta dos versos em palavras.", false, 5, "Pequenos Poemas Para Pequenos" },
                    { 50, "Roseana Murray e Roger Mello", "~/img/50/jardins1.jpg", 5, "“Neste livro repousam a mais linda poesia e os mais lindos jardins, à espera de que o leitor os penetre com a mais singela delicadeza.”\r\nA obra traz quinze pequenos poemas que representam os mais diversos jardins.\r\nCom muita delicadeza, Roseana Murray mexe com o imaginário do leitor. Cada poema-pintura faz os pequenos descobrirem a poesia que vive ao seu redor, nas pequenas coisas, como nas flores, por exemplo.\r\nA organização dos poemas com as ilustrações do talentoso e premiado Roger Mello imprime qualidade que sensibiliza adultos e crianças. É um verdadeiro presente em formato de livro.", false, 5, "Jardins" }
                });

            migrationBuilder.InsertData(
                table: "ImagemLivro",
                columns: new[] { "Id", "CaminhoImagem", "DescricaoFoto", "LivroId" },
                values: new object[,]
                {
                    { 1, "~/img/1/o-menino-maluquinho2.jpg", "Foto adicional", 1 },
                    { 2, "~/img/2/maluquinho-de-familia2.jpg", "Foto adicional", 2 },
                    { 3, "~/img/3/como-ser-amigo2.jpg", "Foto adicional", 3 },
                    { 4, "~/img/4/o-tesouro-da-raposa2.jpg", "Foto adicional", 4 },
                    { 5, "~/img/5/a-cesta-da-dona-maricota2.jpg", "Foto adicional", 5 },
                    { 6, "~/img/5/a-cesta-da-dona-maricota3.jpg", "Foto adicional", 5 },
                    { 7, "~/img/6/a-ursinha-que-nao-dormia-sozinha2.jpg", "Foto adicional", 6 },
                    { 8, "~/img/6/a-ursinha-que-nao-dormia-sozinha3.jpg", "Foto adicional", 6 },
                    { 9, "~/img/7/coraline2.jpg", "Foto adicional", 7 },
                    { 10, "~/img/7/coraline3.jpg", "Foto adicional", 7 },
                    { 11, "~/img/8/as-aventuras-de-nino2.jpg", "Foto adicional", 8 },
                    { 12, "~/img/9/menina-bonita-do-laco-de-fita2.jpg", "Foto adicional", 9 },
                    { 13, "~/img/9/menina-bonita-do-laco-de-fita3.jpg", "Foto adicional   ", 9 },
                    { 14, "~/img/9/menina-bonita-do-laco-de-fita4.jpg", "Foto adicional", 9 },
                    { 15, "~/img/12/o-pedido-da-fada-madrinha2.jpg", "Foto adicional", 12 },
                    { 16, "~/img/12/o-pedido-da-fada-madrinha3.jpg", "Foto adicional", 12 },
                    { 17, "~/img/12/o-pedido-da-fada-madrinha4.jpg", "Foto adicional", 12 },
                    { 18, "~/img/13/chapeuzinho-vermelho2.jpg", "Foto adicional", 13 },
                    { 19, "~/img/13/chapeuzinho-vermelho3.jpg", "Foto adicional", 13 },
                    { 20, "~/img/15/a-primaveira-da-lagarta2.jpg", "Foto adicional", 15 },
                    { 21, "~/img/16/joao-e-o-pe-de-feijao2.jpg", "Foto adicional", 16 },
                    { 22, "~/img/16/joao-e-o-pe-de-feijao3.jpg", "Foto adicional", 16 },
                    { 23, "~/img/16/joao-e-o-pe-de-feijao4.jpg", "Foto adicional", 16 },
                    { 24, "~/img/17/os-tres-porquinhos2.jpg", "Foto adicional", 17 },
                    { 25, "~/img/17/os-tres-porquinhos3.jpg", "Foto adicional", 17 },
                    { 26, "~/img/17/os-tres-porquinhos4.jpg", "Foto adicional", 17 },
                    { 27, "~/img/18/o-pequeno-principe2.jpg", "Foto adicional", 18 },
                    { 28, "~/img/18/o-pequeno-principe3.jpg", "Foto adicional", 18 },
                    { 29, "~/img/19/o-patinho-feio2.jpg", "Foto adicional", 19 },
                    { 30, "~/img/21/a-cigarra-e-a-formiga2.jpg", "Foto adicional", 21 },
                    { 31, "~/img/23/a-lebre-e-a-tartaruga2.jpg", "Foto adicional ", 23 },
                    { 32, "~/img/23/a-lebre-e-a-tartaruga3.jpg", "Foto adicional", 23 },
                    { 33, "~/img/24/fabulas-de-escopo2.jpg", "Foto adicional", 24 },
                    { 34, "~/img/25/perigoso-contem-coelhos2.jpg", "Foto adicional", 25 },
                    { 35, "~/img/25/perigoso-contem-coelhos3.jpg", "Foto adicional", 25 },
                    { 36, "~/img/27/a-raposa-e-as-uvas2.jpg", "Foto adicional", 27 },
                    { 37, "~/img/30/simao-e-o-osso2.jpg", "Foto adicional", 30 },
                    { 38, "~/img/30/simao-e-o-osso3.jpg", "Foto adicional", 30 },
                    { 39, "~/img/33/dragoes-de-terrazul2.jpg", "Foto adicional", 33 },
                    { 40, "~/img/33/dragoes-de-terrazul3.jpg", "Foto adicional", 33 },
                    { 41, "~/img/33/dragoes-de-terrazul4.jpg", "Foto adicional", 33 },
                    { 42, "~/img/34/chorar-e-como-chover2.jpg", "Foto adicional", 34 },
                    { 43, "~/img/34/chorar-e-como-chover3.jpg", "Foto adicional", 34 },
                    { 44, "~/img/34/chorar-e-como-chover4.jpg", "Foto adicional", 34 },
                    { 45, "~/img/35/maluquinho-de-familia2.jpg", "Foto adicional", 35 },
                    { 46, "~/img/35/maluquinho-de-familia3.jpg", "Foto adicional", 35 },
                    { 47, "~/img/35/maluquinho-de-familia4.jpg", "Foto adicional", 35 },
                    { 48, "~/img/37/zumbi-net2.jpg", "Foto adicional", 37 },
                    { 49, "~/img/37/zumbi-net3.jpg", "Foto adicional", 37 },
                    { 50, "~/img/38/gildo2.jpg", "Foto adicional", 38 },
                    { 51, "~/img/39/o-reino-do-tempo2.jpg", "Foto adicional", 39 },
                    { 52, "~/img/40/alice-no-pais-das-maravilhas2.jpg", "Foto adicional", 40 },
                    { 53, "~/img/40/alice-no-pais-das-maravilhas3.jpg", "Foto adicional", 40 },
                    { 54, "~/img/40/alice-no-pais-das-maravilhas4.jpg", "Foto adicional", 40 },
                    { 55, "~/img/41/a-arca-de-noe2.jpg", "Foto adicional", 41 },
                    { 56, "~/img/42/som-do-rugido-da-onca2.jpg", "Foto adicional", 42 },
                    { 57, "~/img/42/som-do-rugido-da-onca3.jpg", "Foto adicional", 42 },
                    { 58, "~/img/42/som-do-rugido-da-onca4.jpg", "Foto adicional", 42 },
                    { 59, "~/img/43/cantigas-de-roda3.jpg", "Foto adicional", 43 },
                    { 60, "~/img/44/mas-que-festa2.jpg", "Foto adicional", 44 },
                    { 61, "~/img/44/mas-que-festa3.jpg", "Foto adicional", 44 },
                    { 62, "~/img/44/mas-que-festa4.jpg", "Foto adicional", 44 },
                    { 63, "~/img/45/o-caso-dos-ovos2.jpg", "Foto adicional", 45 },
                    { 64, "~/img/46/catigamente2.jpg", "Foto adicional", 46 },
                    { 65, "~/img/47/versos-magicos2.jpg", "Foto adicional", 47 },
                    { 66, "~/img/48/poemas-para-brincar2.jpg", "Foto adicional", 48 },
                    { 67, "~/img/50/jardins2.jpg", "Foto adicional", 50 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_LivroId",
                table: "Avaliacoes",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_LivroId",
                table: "Comentarios",
                column: "LivroId");

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
                name: "IX_PerfilRegras_RoleId",
                table: "PerfilRegras",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Usuario",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Usuario",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLogin_UserId",
                table: "UsuarioLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPerfil_RoleId",
                table: "UsuarioPerfil",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRegras_UserId",
                table: "UsuarioRegras",
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
                name: "PerfilRegras");

            migrationBuilder.DropTable(
                name: "UsuarioLogin");

            migrationBuilder.DropTable(
                name: "UsuarioPerfil");

            migrationBuilder.DropTable(
                name: "UsuarioRegras");

            migrationBuilder.DropTable(
                name: "UsuarioToken");

            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Classificacoes");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
