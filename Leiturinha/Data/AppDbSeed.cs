using Leiturinha.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Leiturinha.Data
{
    public class AppDbSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // generos
            modelBuilder.Entity<Genero>().HasData(
                new Genero { Id = 1, Nome = "Aventura" },
                new Genero { Id = 2, Nome = "Contos" },
                new Genero { Id = 3, Nome = "Fábulas" },
                new Genero { Id = 4, Nome = "Fantasia" },
                new Genero { Id = 5, Nome = "Poesia infantil" }
            );

            // classificações
            modelBuilder.Entity<ClassificacaoIndicativa>().HasData(
                new ClassificacaoIndicativa { Id = 1, FaixaEtaria = "0–2 anos" },
                new ClassificacaoIndicativa { Id = 2, FaixaEtaria = "3–5 anos" },
                new ClassificacaoIndicativa { Id = 3, FaixaEtaria = "6–7 anos" },
                new ClassificacaoIndicativa { Id = 4, FaixaEtaria = "8–9 anos" },
                new ClassificacaoIndicativa { Id = 5, FaixaEtaria = "10–12 anos" }
            );

            // livros (somente propriedades escalares)
            modelBuilder.Entity<Livro>().HasData(
               new Livro
               {
                   Id = 1,
                   Titulo = "O Menino Maluquinho",
                   Autor = "Ziraldo",
                   Descricao = "O Menino Maluquinho é um garoto alegre, criativo e cheio de energia. Com suas travessuras, brincadeiras e versinhos, ele espalha diversão por onde passa e mostra que a verdadeira felicidade está na amizade e no amor.",
                   Capa = "~/img/1/o-menino-maluquinho1.jpg",
                   GeneroId = 1,
                   ClassificacaoIndicativaId = 2,
                   Destaque = false
               },
               new Livro
               {
                   Id = 2,
                   Titulo = "Maluquinho de família",
                   Autor = "Ziraldo",
                   Descricao = "Ao investigar suas origens para um trabalho escolar sobre a família real do Brasil, o Menino Maluquinho percebe que não sabe nada sobre sua genealogia. Com a ajuda do álbum de fotos antigas do avô, ele embarca numa divertida jornada pelas memórias da família e descobre que a maluquice é uma herança de sangue.",
                   Capa = "~/img/2/maluquinho-de-familia1.jpg",
                   GeneroId = 1,
                   ClassificacaoIndicativaId = 3,
                   Destaque = false
               },
               new Livro
               {
                   Id = 3,
                   Titulo = "Como ser Amigo: um Livro Sobre Amizade",
                   Autor = "Molly Wigand",
                   Descricao = "Neste livro, Molly Wigand ensina às crianças os pilares de uma boa amizade — lealdade, verdade e honestidade — e mostra, de forma acessível e carinhosa, como elas podem cultivar relações saudáveis e se tornar ótimos amigos.",
                   Capa = "~/img/3/como-ser-amigo1.jpg",
                   GeneroId = 5,
                   ClassificacaoIndicativaId = 4,
                   Destaque = true
               },
               new Livro
               {
                   Id = 4,
                   Titulo = "O tesouro da raposa",
                   Autor = "Ana Maria Machado",
                   Descricao = "A simpática Raposa revelou a Mico Maneco que tem um tesouro. Curioso, Maneco faz de tudo para descobrir onde se esconde tanta riqueza.",
                   Capa = "~/img/4/o-tesouro-da-raposa1.jpg",
                   GeneroId = 1,
                   ClassificacaoIndicativaId = 3,
                   Destaque = false
               },
               new Livro
               {
                   Id = 6,
                   Titulo = "A ursinha que não queria dormir sozinha",
                   Autor = "Emília Nuñez",
                   Descricao = "A história acompanha Ursita, uma filhotinha que adora dormir na cama dos pais. Com carinho e apoio da família, ela aprende a ter confiança para dormir sozinha em sua própria caminha, descobrindo que sonhos tranquilos também podem acontecer ali.",
                   Capa = "~/img/6/a-ursinha-que-nao-dormia-sozinha1.jpg",
                   GeneroId = 1,
                   ClassificacaoIndicativaId = 2,
                   Destaque = true
               },
               new Livro
               {
                   Id = 7,
                   Titulo = "Coraline",
                   Autor = "Neil Gaiman",
                   Descricao = "Ao se mudar para uma casa antiga com os pais, Coraline descobre uma porta secreta que a leva a um mundo paralelo. Lá, tudo parece perfeito: seus \"outros pais\" são atenciosos e o ambiente é encantador. Mas logo ela percebe que esse universo esconde perigos sombrios, e retornar à sua verdadeira casa será uma jornada assustadora e desafiadora.",
                   Capa = "~/img/7/coraline1.jpg",
                   GeneroId = 1,
                   ClassificacaoIndicativaId = 5,
                   Destaque = true
               },
               new Livro
               {
                   Id = 8,
                   Titulo = "As Aventuras do Nino - Volume 1: Nino Aprende a Esperar & Nino e o Som Misterioso & Nino e o Tesouro Esquecido",
                   Autor = "Joana Bragança",
                   Descricao = "Nino Aprende a Esperar, Nino e o Som Misterioso e Nino e o Tesouro Esquecido são três histórias ilustradas e encantadoras que acompanham o esquilo Nino enquanto descobre valores importantes como a paciência, a coragem e a honestidade.",
                   Capa = "~/img/8/as-aventuras-de-nino1.jpg",
                   GeneroId = 1,
                   ClassificacaoIndicativaId = 3,
                   Destaque = false
               },
               new Livro
               {
                   Id = 9,
                   Titulo = "Menina bonita do laço de fita",
                   Autor = "Ana Maria Machado",
                   Descricao = "Uma linda menina negra desperta a admiração de um coelho branco, que deseja ter uma filha tão pretinha quanto ela. Cada vez que ele lhe pergunta qual o segredo de sua cor, ela inventa uma história.",
                   Capa = "~/img/9/menina-bonita-do-laco-de-fita1.jpg",
                   GeneroId = 1,
                   ClassificacaoIndicativaId = 4,
                   Destaque = true
               },
               new Livro
               {
                   Id = 10,
                   Titulo = "Meu Amigo, o Canguru",
                   Autor = "Ziraldo",
                   Descricao = "Ziraldo relembra sua infância. Na enciclopédia, entre o A e o F, ele encontrou a figura de um canguru. Foi amor à primeira vista.",
                   Capa = "~/img/10/meu-amigo-canguru1.jpg",
                   GeneroId = 1,
                   ClassificacaoIndicativaId = 4,
                   Destaque = true
               },
               new Livro
               {
                   Id = 11,
                   Titulo = "O pedido da Fada Madrinha",
                   Autor = "Janaina Tokitaka",
                   Descricao = "A Fada Madrinha está cansada! Hoje é o aniversário dela e ela resolve tirar um dia de folga. O que acontecerá com o reino encantado?",
                   Capa = "~/img/12/o-pedido-da-fada-madrinha1.jpg",
                   GeneroId = 2,
                   ClassificacaoIndicativaId = 3,
                   Destaque = false
               },
               new Livro
               {
                   Id = 12,
                   Titulo = "Camilão, o comilão",
                   Autor = "Ana Maria Machado",
                   Descricao = "Conheça o Camilo, um simpático leitão, amigo de todo mundo, mas um grande comilão!",
                   Capa = "~/img/14/camilao-o-comilao1.jpg",
                   GeneroId = 3,
                   ClassificacaoIndicativaId = 3,
                   Destaque = false
               },
               new Livro
               {
                   Id = 13,
                   Titulo = "A primavera da lagarta",
                   Autor = "Ruth Rocha",
                   Descricao = "Depois de uma reunião debaixo da bananeira da floresta, os bichos decidem caçar a lagarta.",
                   Capa = "~/img/15/a-primaveira-da-lagarta1.jpg",
                   GeneroId = 3,
                   ClassificacaoIndicativaId = 4,
                   Destaque = true
               },
               new Livro
               {
                   Id = 14,
                   Titulo = "O Pequeno Príncipe",
                   Autor = "Antoine de Saint-Exupéry",
                   Descricao = "Um piloto encontra um pequeno príncipe que o leva a uma aventura filosófica e poética.",
                   Capa = "~/img/18/o-pequeno-principe1.jpg",
                   GeneroId = 3,
                   ClassificacaoIndicativaId = 5,
                   Destaque = true
               },
               new Livro
               {
                   Id = 15,
                   Titulo = "O Patinho Feio",
                   Autor = "Vários Autores",
                   Descricao = "O patinho feio é rejeitado por sua família e parte em busca de aceitação.",
                   Capa = "~/img/19/o-patinho-feio1.jpg",
                   GeneroId = 2,
                   ClassificacaoIndicativaId = 3,
                   Destaque = false
               },
               new Livro
               {
                   Id = 16,
                   Titulo = "O Soldadinho de Chumbo: e Outros Contos de Andersen",
                   Autor = "Christian Hans Andersen",
                   Descricao = "Contos clássicos de Andersen compilados neste volume.",
                   Capa = "~/img/20/o-soldadinho-de-chumbo.jpg",
                   GeneroId = 2,
                   ClassificacaoIndicativaId = 5,
                   Destaque = false
               },
               new Livro
               {
                   Id = 17,
                   Titulo = "O sanduíche da Maricota",
                   Autor = "Avelino Guedes",
                   Descricao = "A galinha Maricota prepara um sanduíche e a bicharada dá palpites.",
                   Capa = "~/img/22/o-sanduiche-da-maricota.jpg",
                   GeneroId = 3,
                   ClassificacaoIndicativaId = 3,
                   Destaque = true
               },
               new Livro
               {
                   Id = 18,
                   Titulo = "Perigoso! Este Livro Contém Coelhos!",
                   Autor = "Tim Warnes",
                   Descricao = "Uma história hilária sobre amizade e rótulos.",
                   Capa = "~/img/25/perigoso-contem-coelhos1.jpg",
                   GeneroId = 3,
                   ClassificacaoIndicativaId = 3,
                   Destaque = true
               },
               new Livro
               {
                   Id = 19,
                   Titulo = "O rato do campo e o rato da cidade",
                   Autor = "Ruth Rocha",
                   Descricao = "Uma deliciosa fábula sobre diferenças entre campo e cidade.",
                   Capa = "~/img/26/rato-do-campo-e-da-cidade.jpg",
                   GeneroId = 3,
                   ClassificacaoIndicativaId = 2,
                   Destaque = false
               },
               new Livro
               {
                   Id = 20,
                   Titulo = "A raposa e as uvas",
                   Autor = "Ciranda Cultural",
                   Descricao = "Uma história sobre humildade e paciência.",
                   Capa = "~/img/27/a-raposa-e-as-uvas1.jpg",
                   GeneroId = 3,
                   ClassificacaoIndicativaId = 3,
                   Destaque = false
               },
               new Livro
               {
                   Id = 21,
                   Titulo = "Contos de Muitos Povos",
                   Autor = "Tatiana Belinky",
                   Descricao = "Contos populares recontados com leveza e humor.",
                   Capa = "~/img/28/contos-de-muitos-povos.jpg",
                   GeneroId = 3,
                   ClassificacaoIndicativaId = 4,
                   Destaque = false
               },
               new Livro
               {
                   Id = 22,
                   Titulo = "O Lobo e os Sete Cabritinhos",
                   Autor = "Pé da Letra",
                   Descricao = "Uma cabra deixa seus sete filhos sozinhos em casa e alerta sobre o Lobo Mau.",
                   Capa = "~/img/29/lobo-e-os-sete-cabritinhos.jpg",
                   GeneroId = 3,
                   ClassificacaoIndicativaId = 1,
                   Destaque = false
               },
               new Livro
               {
                   Id = 23,
                   Titulo = "Simão e o osso",
                   Autor = "Corey Tabor",
                   Descricao = "Uma lição sobre empatia em forma de história infantil.",
                   Capa = "~/img/30/simao-e-o-osso1.jpg",
                   GeneroId = 3,
                   ClassificacaoIndicativaId = 2,
                   Destaque = true
               },
               new Livro
               {
                   Id = 24,
                   Titulo = "O Reino das Cores",
                   Autor = "Geizy Reis",
                   Descricao = "Sete reinos, cada um com uma cor; no fim descobrem o valor da união.",
                   Capa = "~/img/31/o-reino-das-cores.jpg",
                   GeneroId = 4,
                   ClassificacaoIndicativaId = 2,
                   Destaque = false
               },
               new Livro
               {
                   Id = 25,
                   Titulo = "A Floresta Encantada",
                   Autor = "Elisa De Biase Hopman",
                   Descricao = "Várias cenas da floresta descritas com leveza e ilustrações primorosas.",
                   Capa = "~/img/32/a-floresta-encantada.jpg",
                   GeneroId = 4,
                   ClassificacaoIndicativaId = 3,
                   Destaque = false
               },
               new Livro
               {
                   Id = 26,
                   Titulo = "Chorar é como Chover",
                   Autor = "Emília Nuñez",
                   Descricao = "Uma história para refletir sobre emoções da infância.",
                   Capa = "~/img/34/chorar-e-como-chover1.jpg",
                   GeneroId = 4,
                   ClassificacaoIndicativaId = 5,
                   Destaque = true
               },
               new Livro
               {
                   Id = 27,
                   Titulo = "Alice no País das Maravilhas (Classic Edition)",
                   Autor = "Lewis Carroll",
                   Descricao = "Alice segue o Coelho Branco até uma toca e vive aventuras maravilhosas.",
                   Capa = "~/img/40/alice-no-pais-das-maravilhas1.jpg",
                   GeneroId = 4,
                   ClassificacaoIndicativaId = 5,
                   Destaque = true
               },
               new Livro
               {
                   Id = 28,
                   Titulo = "Versos Mágicos",
                   Autor = "Van Macedo",
                   Descricao = "Poemas que inspiram a criatividade dos pequenos leitores.",
                   Capa = "~/img/47/versos-magicos1.jpg",
                   GeneroId = 5,
                   ClassificacaoIndicativaId = 4,
                   Destaque = false
               },
               new Livro
               {
                   Id = 29,
                   Titulo = "Poemas para Brincar",
                   Autor = "José Paulo Paes",
                   Descricao = "Um clássico da poesia infantil brasileira para brincar com a língua.",
                   Capa = "~/img/48/poemas-para-brincar1.jpg",
                   GeneroId = 5,
                   ClassificacaoIndicativaId = 2,
                   Destaque = false
               },
               new Livro
               {
                   Id = 30,
                   Titulo = "Pequenos Poemas Para Pequenos",
                   Autor = "Eduardo Rodrigues",
                   Descricao = "Pequenos poemas que convidam à graça das coisas cotidianas.",
                   Capa = "~/img/49/pequenos-poemas.jpg",
                   GeneroId = 5,
                   ClassificacaoIndicativaId = 3,
                   Destaque = false
               },
               new Livro
               {
                   Id = 31,
                   Titulo = "Jardins",
                   Autor = "Roseana Murray e Roger Mello",
                   Descricao = "Quinze pequenos poemas que representam jardins variados.",
                   Capa = "~/img/50/jardins1.jpg",
                   GeneroId = 5,
                   ClassificacaoIndicativaId = 5,
                   Destaque = false
               }
            );

            // imagens de livros
            modelBuilder.Entity<ImagemLivro>().HasData(
                new ImagemLivro { Id = 1, LivroId = 1, CaminhoImagem = "~/img/1/o-menino-maluquinho2.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 2, LivroId = 2, CaminhoImagem = "~/img/2/maluquinho-de-familia2.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 3, LivroId = 3, CaminhoImagem = "~/img/3/como-ser-amigo2.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 4, LivroId = 6, CaminhoImagem = "~/img/6/a-ursinha-que-nao-dormia-sozinha2.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 5, LivroId = 6, CaminhoImagem = "~/img/6/a-ursinha-que-nao-dormia-sozinha3.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 6, LivroId = 7, CaminhoImagem = "~/img/7/coraline2.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 7, LivroId = 7, CaminhoImagem = "~/img/7/coraline3.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 8, LivroId = 8, CaminhoImagem = "~/img/8/as-aventuras-de-nino2.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 9, LivroId = 9, CaminhoImagem = "~/img/9/menina-bonita-do-laco-de-fita2.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 10, LivroId = 9, CaminhoImagem = "~/img/9/menina-bonita-do-laco-de-fita3.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 11, LivroId = 9, CaminhoImagem = "~/img/9/menina-bonita-do-laco-de-fita4.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 12, LivroId = 11, CaminhoImagem = "~/img/12/o-pedido-da-fada-madrinha2.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 13, LivroId = 11, CaminhoImagem = "~/img/12/o-pedido-da-fada-madrinha3.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 14, LivroId = 11, CaminhoImagem = "~/img/12/o-pedido-da-fada-madrinha4.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 15, LivroId = 23, CaminhoImagem = "~/img/30/simao-e-o-osso3.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 16, LivroId = 26, CaminhoImagem = "~/img/34/chorar-e-como-chover2.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 17, LivroId = 26, CaminhoImagem = "~/img/34/chorar-e-como-chover3.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 18, LivroId = 26, CaminhoImagem = "~/img/34/chorar-e-como-chover4.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 19, LivroId = 27, CaminhoImagem = "~/img/40/alice-no-pais-das-maravilhas2.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 20, LivroId = 27, CaminhoImagem = "~/img/40/alice-no-pais-das-maravilhas3.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 21, LivroId = 27, CaminhoImagem = "~/img/40/alice-no-pais-das-maravilhas4.jpg", DescricaoFoto = "Foto adicional" },

                new ImagemLivro { Id = 22, LivroId = 28, CaminhoImagem = "~/img/47/versos-magicos2.jpg", DescricaoFoto = "Foto adicional" }
            );

            #region Perfis de Usuário
            List<IdentityRole> roles = new()
            {
                new IdentityRole
                {
                    Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },
                new IdentityRole
                {
                    Id = "bec71b05-8f3d-4849-88bb-0e8d518d2de8",
                    Name = "Funcionário",
                    NormalizedName = "FUNCIONÁRIO"
                },
                new IdentityRole
                {
                    Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                    Name = "Cliente",
                    NormalizedName = "CLIENTE"
                }
            };
            modelBuilder.Entity<IdentityRole>().HasData(roles.ToArray());
            #endregion

            #region Usuário Padrão
            List<Usuario> usuarios = new()
            {
                new Usuario
                {
                    Id = "a1f1a6c2-1111-4b1e-bf6e-2a9f5f4a9f01",
                    Email = "taynasuperti@gmail.com",
                    NormalizedEmail = "TAYNASUPERTI@GMAIL.COM",
                    UserName = "taynasuperti",
                    NormalizedUserName = "TAYNASUPERTI",
                    LockoutEnabled = true,
                    EmailConfirmed = true,
                    Nome = "Tayná Carolina Miguel Superti",
                    DataNascimento = new DateTime(2006, 11, 6),
                    Foto = "/img/usuarios/no-photo.png"
                }
            };

            PasswordHasher<Usuario> hasher = new();
            foreach (var user in usuarios)
            {
                user.PasswordHash = hasher.HashPassword(user, "123456");
            }
            modelBuilder.Entity<Usuario>().HasData(usuarios.ToArray());
            #endregion

            #region Relacionamento Usuário-Perfil
            List<IdentityUserRole<string>> userRoles = new()
            {
                new IdentityUserRole<string>
                {
                    UserId = usuarios[0].Id,
                    RoleId = roles[0].Id // Administrador
                },
                new IdentityUserRole<string>
                {
                    UserId = usuarios[0].Id,
                    RoleId = roles[1].Id // Funcionário
                },
                new IdentityUserRole<string>
                {
                    UserId = usuarios[0].Id,
                    RoleId = roles[2].Id // Cliente
                }
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles.ToArray());
            #endregion
        }
    }
}