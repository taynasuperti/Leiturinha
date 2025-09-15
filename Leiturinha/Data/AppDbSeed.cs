using Leiturinha.Models;
using System.Security.Cryptography.Xml;

namespace Leiturinha.Data
{
    public class AppDbSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genero>().HasData(
                new Genero { Id = 1, Nome = "Aventura" },
                new Genero { Id = 2, Nome = "Contos de fadas" },
                new Genero { Id = 3, Nome = "Fábulas" },
                new Genero { Id = 4, Nome = "Fantasia" },
                new Genero { Id = 5, Nome = "Poesia infantil" }
            );
            modelBuilder.Entity<ClassificacaoIndicativa>().HasData(
                new ClassificacaoIndicativa { Id = 1, FaixaEtaria = "0–2 anos" },
                new ClassificacaoIndicativa { Id = 2, FaixaEtaria = "3–5 anos" },
                new ClassificacaoIndicativa { Id = 3, FaixaEtaria = "6–7 anos" },
                new ClassificacaoIndicativa { Id = 4, FaixaEtaria = "8–9 anos" },
                new ClassificacaoIndicativa { Id = 5, FaixaEtaria = "10–12 anos" }
            );

            modelBuilder.Entity<Livro>().HasData(
               // Livros de Aventura
               new Livro
               {
                   Id = 1,
                   Titulo = "O Menino Maluquinho",
                   Autor = "Ziraldo",
                   Descricao = "Aventuras de um menino travesso e criativo, explorando amizade e imaginação.",
                   Capa = "capas/o_menino_maluquinho.jpg",
                   GeneroId = 1, // Aventura
                   ClassificacaoIndicativaId = 2 // 3–5 anos
               },
                new Livro
                {
                    Id = 2,
                    Titulo = "O Menino Maluquinho e a Árvore",
                    Autor = "Ziraldo",
                    Descricao = "O Menino Maluquinho enfrenta aventuras e descobre valores como amizade e respeito.",
                    Capa = "capas/o_menino_maluquinho_arvore.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 3,
                    Titulo = "O Mistério do Cinco Estrelas",
                    Autor = "Ruth Rocha",
                    Descricao = "Uma aventura investigativa que ensina raciocínio lógico e valores de amizade.",
                    Capa = "capas/misterio_cinco_estrelas.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 4 // 8–9 anos
                },
                new Livro
                {
                    Id = 4,
                    Titulo = "O Tesouro da Ilha",
                    Autor = "Ana Maria Machado",
                    Descricao = "Aventura de crianças em busca de um tesouro, aprendendo sobre coragem e trabalho em equipe.",
                    Capa = "capas/tesouro_da_ilha.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 5,
                    Titulo = "O Segredo do Sótão",
                    Autor = "Tatiana Belinky",
                    Descricao = "História cheia de mistérios que estimula a curiosidade e imaginação.",
                    Capa = "capas/segredo_sotao.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 4 // 8–9 anos
                },
                new Livro
                {
                    Id = 6,
                    Titulo = "Aventuras de Gui e Lili",
                    Autor = "Emília Nuñez",
                    Descricao = "Duas crianças enfrentam desafios e aventuras, aprendendo valores importantes.",
                    Capa = "capas/aventuras_gui_lili.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 2 // 3–5 anos
                },
                new Livro
                {
                    Id = 7,
                    Titulo = "O Mistério do Livro Perdido",
                    Autor = "Ruth Rocha",
                    Descricao = "Crianças descobrem segredos e resolvem mistérios em uma biblioteca antiga.",
                    Capa = "capas/misterio_livro_perdido.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 5 // 10–12 anos
                },
                new Livro
                {
                    Id = 8,
                    Titulo = "As Aventuras de Nino",
                    Autor = "Odilon Moraes",
                    Descricao = "Histórias de Nino enfrentando desafios e explorando novos mundos.",
                    Capa = "capas/aventuras_nino.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 9,
                    Titulo = "O Tesouro do Bairro",
                    Autor = "Ana Maria Machado",
                    Descricao = "Crianças do bairro descobrem um tesouro escondido e aprendem sobre amizade e ética.",
                    Capa = "capas/tesouro_bairro.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 4 // 8–9 anos
                },
                new Livro
                {
                    Id = 10,
                    Titulo = "Viagem ao Mundo da Imaginação",
                    Autor = "Ziraldo",
                    Descricao = "Menino explora mundos fantásticos, estimulando criatividade e imaginação.",
                    Capa = "capas/viagem_imaginacao.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 5 // 10–12 anos
                },

            //Livros de Conto de Fadas
                new Livro
                {
                    Id = 11,
                    Titulo = "Branca de Neve e os Sete Anões",
                    Autor = "Ana Maria Machado",
                    Descricao = "Uma releitura encantadora do clássico conto de fadas, com ilustrações e linguagem acessível.",
                    Capa = "capas/branca_neve.jpg",
                    GeneroId = 2, // Contos de fadas
                    ClassificacaoIndicativaId = 2 // 3–5 anos
                },
                new Livro
                {
                    Id = 12,
                    Titulo = "Cinderela e a Fada Madrinha",
                    Autor = "Ruth Rocha",
                    Descricao = "História clássica de superação e magia, adaptada para crianças brasileiras.",
                    Capa = "capas/cinderela.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 13,
                    Titulo = "Chapeuzinho Vermelho e o Lobo Mau",
                    Autor = "Tatiana Belinky",
                    Descricao = "Releitura do conto clássico, ensinando sobre coragem e cuidado com estranhos.",
                    Capa = "capas/chapeuzinho_vermelho.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 2 // 3–5 anos
                },
                new Livro
                {
                    Id = 14,
                    Titulo = "A Bela Adormecida",
                    Autor = "Ana Maria Machado",
                    Descricao = "Um conto de fadas com linguagem lúdica, ideal para estimular a imaginação.",
                    Capa = "capas/bela_adormecida.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 15,
                    Titulo = "Rapunzel: O Cabelo Mágico",
                    Autor = "Ruth Rocha",
                    Descricao = "História clássica de Rapunzel, com foco na coragem e amizade.",
                    Capa = "capas/rapunzel.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 4 // 8–9 anos
                },
                new Livro
                {
                    Id = 16,
                    Titulo = "João e o Pé de Feijão",
                    Autor = "Tatiana Belinky",
                    Descricao = "Aventuras de João com o feijão mágico, estimulando imaginação e criatividade.",
                    Capa = "capas/joao_pe_de_feijao.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 17,
                    Titulo = "Os Três Porquinhos",
                    Autor = "Ana Maria Machado",
                    Descricao = "Releitura do clássico conto sobre inteligência e persistência.",
                    Capa = "capas/tres_porquinhos.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 2 // 3–5 anos
                },
                new Livro
                {
                    Id = 18,
                    Titulo = "A Princesa e o Sapo",
                    Autor = "Ruth Rocha",
                    Descricao = "Uma história encantadora sobre amor, coragem e transformação.",
                    Capa = "capas/princesa_sapo.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 4 // 8–9 anos
                },
                new Livro
                {
                    Id = 19,
                    Titulo = "O Patinho Feio",
                    Autor = "Tatiana Belinky",
                    Descricao = "Clássico conto que ensina sobre autoestima, aceitação e superação.",
                    Capa = "capas/patinho_feio.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 20,
                    Titulo = "O Soldadinho de Chumbo",
                    Autor = "Ana Maria Machado",
                    Descricao = "Um conto de fadas emocionante que estimula empatia e imaginação.",
                    Capa = "capas/soldadinho_chumbo.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 5 // 10–12 anos
                },

            // Livros de Fábulas
                new Livro
                {
                    Id = 21,
                    Titulo = "A Formiga e a Cigarra",
                    Autor = "Ruth Rocha",
                    Descricao = "Uma releitura da clássica fábula que ensina sobre planejamento e esforço.",
                    Capa = "capas/formiga_cigarra.jpg",
                    GeneroId = 3, // Fábulas
                    ClassificacaoIndicativaId = 2 // 3–5 anos
                },
                new Livro
                {
                    Id = 22,
                    Titulo = "O Leão e o Rato",
                    Autor = "Tatiana Belinky",
                    Descricao = "Fábula que mostra como pequenos gestos podem fazer grande diferença.",
                    Capa = "capas/leao_rato.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 23,
                    Titulo = "A Lebre e a Tartaruga",
                    Autor = "Ana Maria Machado",
                    Descricao = "História que ensina sobre persistência, humildade e paciência.",
                    Capa = "capas/lebre_tartaruga.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 2 // 3–5 anos
                },
                new Livro
                {
                    Id = 24,
                    Titulo = "O Corvo e a Raposa",
                    Autor = "Ruth Rocha",
                    Descricao = "Uma fábula divertida que ensina sobre vaidade e astúcia.",
                    Capa = "capas/corvo_raposa.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 25,
                    Titulo = "A Cigarra e o Tigre",
                    Autor = "Tatiana Belinky",
                    Descricao = "Fábula moderna que aborda amizade e colaboração em situações inesperadas.",
                    Capa = "capas/cigarra_tigre.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 4 // 8–9 anos
                },
                new Livro
                {
                    Id = 26,
                    Titulo = "O Gato e o Escorpião",
                    Autor = "Ana Maria Machado",
                    Descricao = "Fábula que ensina sobre confiança e consequências das ações.",
                    Capa = "capas/gato_escorpiao.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 5 // 10–12 anos
                },
                new Livro
                {
                    Id = 27,
                    Titulo = "A Raposa e as Uvas",
                    Autor = "Ruth Rocha",
                    Descricao = "História que ensina sobre frustração e a importância de lidar com obstáculos.",
                    Capa = "capas/raposa_uvas.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 28,
                    Titulo = "O Leão e o Camaleão",
                    Autor = "Tatiana Belinky",
                    Descricao = "Fábula que mostra a importância da adaptabilidade e respeito às diferenças.",
                    Capa = "capas/leao_camaleao.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 4 // 8–9 anos
                },
                new Livro
                {
                    Id = 29,
                    Titulo = "O Lobo e os Sete Cabritinhos",
                    Autor = "Ana Maria Machado",
                    Descricao = "Releitura da fábula clássica, enfatizando cuidado e coragem.",
                    Capa = "capas/lobo_sete_cabritinhos.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 30,
                    Titulo = "O Cão e o Osso",
                    Autor = "Ruth Rocha",
                    Descricao = "Fábula que ensina sobre ganância e apreciação do que se tem.",
                    Capa = "capas/cao_osso.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 2 // 3–5 anos
                },

            //Livros de Fantasia
                new Livro
                {
                    Id = 31,
                    Titulo = "O Reino das Cores",
                    Autor = "Ruth Rocha",
                    Descricao = "Crianças entram em um mundo mágico onde aprendem sobre criatividade e amizade.",
                    Capa = "capas/reino_das_cores.jpg",
                    GeneroId = 4, // Fantasia
                    ClassificacaoIndicativaId = 2 // 3–5 anos
                },
                new Livro
                {
                    Id = 32,
                    Titulo = "A Floresta Encantada",
                    Autor = "Ana Maria Machado",
                    Descricao = "História de crianças que exploram uma floresta cheia de seres fantásticos e aventuras.",
                    Capa = "capas/floresta_encantada.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 33,
                    Titulo = "O Dragão da Montanha",
                    Autor = "Tatiana Belinky",
                    Descricao = "Um menino enfrenta um dragão mágico e aprende sobre coragem e inteligência.",
                    Capa = "capas/dragao_montanha.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 4 // 8–9 anos
                },
                new Livro
                {
                    Id = 34,
                    Titulo = "A Cidade Submersa",
                    Autor = "Emília Nuñez",
                    Descricao = "Aventuras em uma cidade mágica submersa, estimulando imaginação e raciocínio.",
                    Capa = "capas/cidade_submersa.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 5 // 10–12 anos
                },
                new Livro
                {
                    Id = 35,
                    Titulo = "O Castelo de Vidro",
                    Autor = "Ana Maria Machado",
                    Descricao = "Crianças exploram um castelo encantado cheio de enigmas e criaturas fantásticas.",
                    Capa = "capas/castelo_de_vidro.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 4 // 8–9 anos
                },
                new Livro
                {
                    Id = 36,
                    Titulo = "A Fada do Jardim",
                    Autor = "Ruth Rocha",
                    Descricao = "Uma fada ajuda crianças a superar desafios mágicos em um jardim encantado.",
                    Capa = "capas/fada_jardim.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 2 // 3–5 anos
                },
                new Livro
                {
                    Id = 37,
                    Titulo = "O Reino das Sombras",
                    Autor = "Tatiana Belinky",
                    Descricao = "História de aventura e fantasia, com mistérios que estimulam a criatividade.",
                    Capa = "capas/reino_das_sombras.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 5 // 10–12 anos
                },
                new Livro
                {
                    Id = 38,
                    Titulo = "As Aventuras de Lila e Leo",
                    Autor = "Emília Nuñez",
                    Descricao = "Crianças viajam por mundos fantásticos enfrentando desafios e fazendo novos amigos.",
                    Capa = "capas/aventuras_lila_leo.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 39,
                    Titulo = "O Reino do Tempo",
                    Autor = "Ana Maria Machado",
                    Descricao = "Meninos e meninas exploram um reino mágico onde o tempo é diferente, aprendendo valores importantes.",
                    Capa = "capas/reino_do_tempo.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 4 // 8–9 anos
                },
                new Livro
                {
                    Id = 40,
                    Titulo = "O Livro das Maravilhas",
                    Autor = "Ruth Rocha",
                    Descricao = "Crianças descobrem um livro mágico que as transporta para mundos fantásticos e aventuras.",
                    Capa = "capas/livro_das_maravilhas.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 5 // 10–12 anos
                },

            //Livros de Poesias Infantis
                new Livro
                {
                    Id = 41,
                    Titulo = "A Arca de Noé",
                    Autor = "Vinícius de Moraes",
                    Descricao = "Poemas lúdicos que exploram animais e a imaginação infantil.",
                    Capa = "capas/arca_de_noe.jpg",
                    GeneroId = 5, // Poesia Infantil
                    ClassificacaoIndicativaId = 2 // 3–5 anos
                },
                new Livro
                {
                    Id = 42,
                    Titulo = "O Livro das Onças",
                    Autor = "Cecília Meireles",
                    Descricao = "Poemas com linguagem poética e rítmica, estimulando criatividade e leitura em voz alta.",
                    Capa = "capas/livro_das_oncas.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 43,
                    Titulo = "Cantigas de Roda",
                    Autor = "Ruth Rocha",
                    Descricao = "Coletânea de poesias e cantigas tradicionais que encantam crianças pequenas.",
                    Capa = "capas/cantigas_de_roda.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 2 // 3–5 anos
                },
                new Livro
                {
                    Id = 44,
                    Titulo = "Menina Bonita do Laço de Fita",
                    Autor = "Ana Maria Machado",
                    Descricao = "Poemas que exploram diversidade, autoestima e encantamento infantil.",
                    Capa = "capas/menina_bonita_laco_fita.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 45,
                    Titulo = "Poemas e Versos para Crianças",
                    Autor = "Tatiana Belinky",
                    Descricao = "Coletânea divertida de poemas curtos, ideal para leitura em família.",
                    Capa = "capas/poemas_versos_criancas.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 4 // 8–9 anos
                },
                new Livro
                {
                    Id = 46,
                    Titulo = "O Cão e o Gato: Poemas",
                    Autor = "Emília Nuñez",
                    Descricao = "Poesias que exploram amizade, animais e situações do cotidiano infantil.",
                    Capa = "capas/cao_gato_poemas.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 47,
                    Titulo = "Versos Mágicos",
                    Autor = "Ruth Rocha",
                    Descricao = "Poemas cheios de fantasia e magia, estimulando criatividade e imaginação.",
                    Capa = "capas/versos_magicos.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 4 // 8–9 anos
                },
                new Livro
                {
                    Id = 48,
                    Titulo = "Poemas para Brincar",
                    Autor = "Cecília Meireles",
                    Descricao = "Poesias curtas, lúdicas e divertidas, ideais para incentivar a leitura inicial.",
                    Capa = "capas/poemas_para_brincar.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 2 // 3–5 anos
                },
                new Livro
                {
                    Id = 49,
                    Titulo = "Pequenos Poemas",
                    Autor = "Ana Maria Machado",
                    Descricao = "Coletânea de poesias simples e encantadoras para crianças em fase inicial de leitura.",
                    Capa = "capas/pequenos_poemas.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 3 // 6–7 anos
                },
                new Livro
                {
                    Id = 50,
                    Titulo = "O Livro da Poesia Infantil",
                    Autor = "Tatiana Belinky",
                    Descricao = "Diversos poemas para estimular o gosto pela leitura e pela rima desde cedo.",
                    Capa = "capas/livro_poesia_infantil.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 5 // 10–12 anos
                }
             );
            modelBuilder.Entity<ImagemLivro>().HasData(
                new ImagemLivro { Id = 1, LivroId = 1, CaminhoImagem = "fotos/menino_maluquinho_1.jpg", DescricaoFoto = "Capa frontal" },
                new ImagemLivro { Id = 2, LivroId = 1, CaminhoImagem = "fotos/menino_maluquinho_2.jpg", DescricaoFoto = "Contra capa" }
            );
        }
    }
}
