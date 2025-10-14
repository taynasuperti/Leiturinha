using Leiturinha.Models;
using System.Security.Cryptography.Xml;
using Microsoft.EntityFrameworkCore;

namespace Leiturinha.Data
{
    public class AppDbSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genero>().HasData(
                new Genero { Id = 1, Nome = "Aventura" },
                new Genero { Id = 2, Nome = "Contos" },
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
                   Descricao = "O Menino Maluquinho é um garoto alegre, criativo e cheio de energia. Com suas travessuras, brincadeiras e versinhos, ele espalha diversão por onde passa e mostra que a verdadeira felicidade está na amizade e no amor.",
                   Capa = "~/img/1/o-menino-maluquinho1.jpg",
                   GeneroId = 1, // Aventura
                   ClassificacaoIndicativaId = 2, // 3–5 anos
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
                    ClassificacaoIndicativaId = 3, // 6–7 anos
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
                    ClassificacaoIndicativaId = 4, // 8–9 anos
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
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 5,
                    Titulo = "A cesta de dona Maricota",
                    Autor = "Tatiana Belinky",
                    Descricao = "Por meio de versos e rimas divertidas, os alimentos da cesta de Dona Maricota ganham vida e destacam os benefícios de uma alimentação saudável com frutas, verduras e legumes. Ideal para crianças do 1º e 2º ano do Ensino Fundamental, o livro promove o aprendizado interdisciplinar com foco em Ciências da Natureza.",
                    Capa = "~/img/5/a-cesta-da-dona-maricota1.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 3, // 8–9 anos
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
                    ClassificacaoIndicativaId = 2, // 3–5 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 7,
                    Titulo = "Coraline",
                    Autor = " Neil Gaiman",
                    Descricao = "Ao se mudar para uma casa antiga com os pais, Coraline descobre uma porta secreta que a leva a um mundo paralelo. Lá, tudo parece perfeito: seus \"outros pais\" são atenciosos e o ambiente é encantador. Mas logo ela percebe que esse universo esconde perigos sombrios, e retornar à sua verdadeira casa será uma jornada assustadora e desafiadora.",
                    Capa = "~/img/7/coraline1.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 5, // 10–12 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 8,
                    Titulo = "As Aventuras do Nino - Volume 1: Nino Aprende a Esperar & Nino e o Som Misterioso & Nino e o Tesouro Esquecido",
                    Autor = "Joana Bragança ",
                    Descricao = "Nino Aprende a Esperar, Nino e o Som Misterioso e Nino e o Tesouro Esquecido são três histórias ilustradas e encantadoras que acompanham o esquilo Nino enquanto descobre valores importantes como a paciência, a coragem e a honestidade.\r\nIdeal para crianças dos 3 aos 7 anos, este livro incentiva o diálogo sobre emoções e atitudes positivas, num universo mágico, colorido e cheio de ternura.",
                    Capa = "~/img/8/as-aventuras-de-nino1.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 9,
                    Titulo = "Menina bonita do laço de fita",
                    Autor = "Ana Maria Machado",
                    Descricao = "Uma linda menina negra desperta a admiração de um coelho branco, que deseja ter uma filha tão pretinha quanto ela. Cada vez que ele lhe pergunta qual o segredo de sua cor, ela inventa uma história. O coelho segue todos os “conselhos” da menina, mas continua branco. Esta narrativa delicada e tocante aborda temas como autoaceitação, respeito às diferenças e a beleza da diversidade. Com ilustrações encantadoras e uma mensagem poderosa, o livro convida os leitores a refletir sobre a importância de valorizar a singularidade de cada pessoa, independentemente de sua cor de pele.",
                    Capa = "~/img/9/menina-bonita-do-laco-de-fita1.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 4, // 8–9 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 10,
                    Titulo = "Meu Amigo, o Canguru",
                    Autor = "Ziraldo",
                    Descricao = "Ziraldo relembra sua infância. Na enciclopédia, entre o A e o F, ele encontrou a figura de um canguru. Foi amor à primeira vista. Gugu foi seu amigo de infância, de sonhos e fantasias, de ternura e aconchego. Ziraldo cresceu, tornou-se escritor, desenhista, artista, e o canguru, sempre à vista.",
                    Capa = "~/img/10/meu-amigo-canguru1.jpg",
                    GeneroId = 1,
                    ClassificacaoIndicativaId = 4, // 10–12 anos --
                    Destaque = true
                },

            //Livros de Conto de Fadas
                new Livro
                {
                    Id = 11,
                    Titulo = "Branca de Neve e os Sete Anões | Livro Quebra-Cabeça",
                    Autor = "Ana Maria Machado",
                    Descricao = "Os mais clássicos contos de fadas em formato diferente para as crianças se divertirem com a historinha ao mesmo tempo que brincam com um quebracabeça à cada página.",
                    Capa = "~/img/11/branca-de-neve.jpg",
                    GeneroId = 2, // Contos de fadas
                    ClassificacaoIndicativaId = 2, // 3–5 anos --
                    Destaque = false
                },
                new Livro
                {
                    Id = 12,
                    Titulo = "O pedido da Fada Madrinha",
                    Autor = "Janaina Tokitaka",
                    Descricao = "A Fada Madrinha está cansada! Afinal, ela trabalha sem parar para atender a todos os pedidos das princesas dos contos de fadas. Mas hoje é uma data especial: é o aniversário da Fada Madrinha! E se ela resolvesse tirar um merecido dia de folga? O que será que aconteceria com o reino encantado?\r\nEsta nova versão da Fada Madrinha apresentada nesta história da coleção Canoa vai mudar a relação que temos com a já tão conhecida personagem de tantos contos de fadas. Escrito por Janaina Tokitaka e ricamente ilustrado por Flávia Borges, este livro vai surpreender, fazer pensar e arrancar risadas de crianças e adultos. A coleção Canoa tem como objetivo levar literatura infantil de qualidade a um preço popular para todos os pequenos leitores.",
                    Capa = "~/img/12/o-pedido-da-fada-madrinha1.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 13,
                    Titulo = "Chapeuzinho Vermelho",
                    Autor = "Susie Brooks",
                    Descricao = "Muito contente, CHAPEUZINHO VERMELHO foi vistar a vovozinha, mas não imaginava que o LOBO MAU estava no lugar da velhinha!",
                    Capa = "~/img/13/chapeuzinho-vermelho1.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 1, // 3–5 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 14,
                    Titulo = "Camilão, o comilão",
                    Autor = "Ana Maria Machado",
                    Descricao = "Conheça o Camilo, um simpático leitão, amigo de todo mundo, mas um grande comilão! Gosta de comer bem, mas nem tanto de trabalhar. Por isso tudo o que come, ele prefere ganhar. Preguiçoso, sem dúvida, mas tem um bom coração. É impossível não amar nosso amigo Camilão!",
                    Capa = "~/img/14/camilao-o-comilao1.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 15,
                    Titulo = "A primavera da lagarta",
                    Autor = "Ruth Rocha",
                    Descricao = "Depois de uma reunião debaixo da bananeira da floresta, a formiga, o louva-a-deus, o camaleão (que vivia mudando de opinião), a joaninha, a lagartixa, a libélula, o gafanhoto, o caracol, a aranha e a cigarra (ufa, quanta gente!, ou melhor, quanto bicho!), decidiram caçar a lagarta, porque ela comia folhas demais (como se eles não comessem nada...). Além disso, eles achavam a lagarta muito feia (como se eles fossem muito lindos...). Porém, a caçada aconteceu no início da primavera, quando as lagartas se transformam em... Bem, é melhor não contar o final da história, que ficou ainda mais bonita com os desenhos da Madalena Elek.",
                    Capa = "~/img/15/a-primaveira-da-lagarta1.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 4, // 8–9 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 16,
                    Titulo = "João e o Pé de Feijão",
                    Autor = "Igor Barbosa ",
                    Descricao = "João mora com sua mãe numa cidade chamada Vila Feliz. Mas como são tempos difíceis, o menino decide trocar a vaca leiteira da família por cinco feijões mágicos que um senhor misterioso ofereceu. Mal sabia ele que aquelas sementes o levariam a uma grande aventura, com o poder de transformar sua vida e o futuro de toda a cidade.",
                    Capa = "~/img/16/joao-e-o-pe-de-feijao1.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 17,
                    Titulo = "Os Três Porquinhos",
                    Autor = "Tulip Books",
                    Descricao = "Dê vida à magia dos contos de fadas para os seus filhos. As histórias atemporais e ilustrações encantadoras nestes livros pop-up logo se tornarão a diversão favorita de todos na hora de dormir e ajudarão seus filhos a cair em um sono mágico e tranquilo.  ",
                    Capa = "~/img/17/os-tres-porquinhos1.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 2,    // 3–5 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 18,
                    Titulo = "O Pequeno Príncipe",
                    Autor = "Antoine de Saint-Exupéry",
                    Descricao = "Nesta história que marcou gerações de leitores em todo o mundo, um piloto cai com seu avião no deserto do Saara e encontra um pequeno príncipe, que o leva a uma aventura filosófica e poética através de planetas que encerram a solidão humana.\r\n\r\nUm livro para todos os públicos, O pequeno príncipe é uma obra atemporal, com metáforas pertinentes e aprendizados sobre afeto, sonhos, esperança e tudo aquilo que é invisível aos olhos. ",
                    Capa = "~/img/18/o-pequeno-principe1.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 5, // 8–9 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 19,
                    Titulo = "O Patinho Feio",
                    Autor = " Vários Autores",
                    Descricao = "O patinho feio é rejeitado por sua família e decide procurar alguém que o aceite como ele é. Leia esta encantadora história e cole os adesivos para completar as cenas.",
                    Capa = "~/img/19/o-patinho-feio1.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 20,
                    Titulo = "O Soldadinho de Chumbo: e Outros Contos de Andersen",
                    Autor = "Christian Hans Andersen ",
                    Descricao = "O Soldadinho de Chumbo A Menina dos Fósforos O Pequeno Tuque As Flores de Idinha A Camponesa e o Limpador de Chaminés As Cegonhas João Grande e João Pequeno O Pinheirinho O Rouxinol.",
                    Capa = "~/img/20/o-soldadinho-de-chumbo.jpg",
                    GeneroId = 2,
                    ClassificacaoIndicativaId = 5, // 10–12 anos
                    Destaque = false
                },

            // Livros de Fábulas
                new Livro
                {
                    Id = 21,
                    Titulo = "A Cigarra e a Formiga",
                    Autor = " Ciranda Cultural",
                    Descricao = "A cigarra passava os dias cantando, despreocupadamente, enquanto a formiga trabalhava sem parar. O inverno chegará... quem estará mais preparada para enfrentar essa estação? Acompanhe a história e descubra a importância da solidariedade e da amizade verdadeira.",
                    Capa = "~/img/21/a-cigarra-e-a-formiga1.jpg",
                    GeneroId = 3, // Fábulas
                    ClassificacaoIndicativaId = 2, // 3–5 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 22,
                    Titulo = "O sanduíche da Maricota",
                    Autor = "Avelino Guedes",
                    Descricao = "A galinha Maricota preparou um sanduíche. Mas, antes de conseguir comer, a bicharada toda começou a chegar e dar palpite para tornar o sanduíche da Maricota mais gostoso (para eles, é claro). O resultado é difícil de explicar. Só mesmo vendo. Vamos ver?",
                    Capa = "~/img/22/o-sanduiche-da-maricota.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 23,
                    Titulo = "A Lebre e a Tartaruga",
                    Autor = " Ruth Rocha",
                    Descricao = "Nesta releitura encantadora, a consagrada Ruth Rocha transforma a clássica fábula sobre a corrida entre a lebre e a tartaruga em uma experiência literária única, em que cada verso e cada rima convidam os leitores a refletirem sobre os valores da perseverança e da humildade.  A lebre e a tartaruga é o quarto livro da coleção Recontos Bonitinhos. Nesta série, Ruth Rocha empresta seu olhar e talento únicos para criar poemas e apresentar histórias clássicas para as novas gerações de pequenos leitores.  Na narrativa, que se inicia com um gostoso convite a adentrar o mundo de imaginação - \"Era uma vez uma lebre, que se achava a tal! Um dia, ela desafiou a tranquila tartaruga para uma corrida sensacional. Quem será que chegou primeiro, afinal?\" - a autora usa a cadência dos versos para dar voz a personagens que, apesar de suas diferenças, ensinam que a jornada da vida pode ser recontada de diversas formas. Abordagem que estimula a criatividade e a sensibilidade, transformando a simples corrida em uma metáfora para os desafios e triunfos cotidianos.  Complementando a narrativa, as ilustrações vibrantes e coloridas de Caco Galhardo dão vida aos personagens e cenários, reforçando o caráter lúdico e inspirador da obra. Cada traço e cor colaboram para que o imaginário infantil se expanda, proporcionando uma experiência visual que dialoga perfeitamente com o texto poético.",
                    Capa = "~/img/23/a-lebre-e-a-tartaruga1.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 2, // 3–5 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 24,
                    Titulo = "Fábulas de Esopo",
                    Autor = "Ruth Rocha",
                    Descricao = "Se de fato existiu (há quem duvide), Esopo foi um grego do século VI a.C. Como se lê num texto ao final deste livrinho, suas fábulas “são pequenas histórias de caráter moral e alegórico, nas quais os principais personagens são representados por animais que pensam e falam como humanos. Ao fazer isso, Esopo queria mostrar como o ser humano pode agir em determinadas situações”.Essas pequenas histórias foram transmitidas ao longo dos séculos, num boca a boca que durou aproximadamente dois mil anos, até que autores como o francês Jean de La Fontaine, que viveu no século XVII, decidiram colocá-las no papel. Agora é a vez da Ruth Rocha, que escolheu algumas das mais interessantes, como “A raposa e as uvas”, “A cigarra e a formiga” e “A rã e o touro”, e a elas emprestou sua voz única, graciosa, especial.\r\n",
                    Capa = "~/img/24/fabulas-de-escopo1.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 25,
                    Titulo = "Perigoso! Este Livro Contém Coelhos!",
                    Autor = "Tim Warnes",
                    Descricao = "O melhor amigo do Bob,uma coisa escamosa,encontrou um chapéu.Havia uma etiqueta nele que dizia:PERIGO! NÃO TOQUE! Tire isso! gritou Bob. Pode ser perigoso!Então, de dentro da cartola saltou um coelho.E depois outro! E outro!Mas os coelhos não são perigosos. São?Uma história hilária sobre amizade.E rótulos...",
                    Capa = "~/img/25/perigoso-contem-coelhos1.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 3, // 8–9 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 26,
                    Titulo = "O rato do campo e o rato da cidade",
                    Autor = "Ruth Rocha",
                    Descricao = "Era uma vez uma família de ratos que morava no campo. “Viviam perto de um celeiro, cheinho de grãos, de maneira que sempre tinham o que comer”, nos conta a Ruth Rocha. Um dia eles receberam a visita de um primo da cidade, Jôni Raturbano, que era grã-fino e, sem querer querendo, sempre dava um jeito de criticar a vida rural. Dizia que na cidade é que era bom. Quando chegou a hora de ir embora, Jôni Raturbano convidou seu primo Rateco para ir com ele. Rateco gostou da ideia. Mas será que a cidade grande trataria bem do nosso ratinho?Da série Conta de Novo, O rato do campo e o rato da cidade é uma deliciosa fábula (atribuída a Esopo) sobre as diferenças entre o campo e a cidade, mas também uma defesa sem concessões à dignidade dos homens, ops, quero dizer, dos ratos.",
                    Capa = "~/img/26/rato-do-campo-e-da-cidade.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 2, // 10–12 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 27,
                    Titulo = "A raposa e as uvas",
                    Autor = "Ciranda Cultural",
                    Descricao = "Uma raposa estava andando pela floresta e com vontade de comer algo doce. Ela se deparou com uma parreira cheinha de belas uvas, mas não conseguia pegá-las. Leia esta história que fala sobre humildade e paciência.",
                    Capa = "~/img/27/a-raposa-e-as-uvas1.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 28,
                    Titulo = "Contos de Muitos Povos",
                    Autor = "Tatiana Belinky",
                    Descricao = "As histórias populares são transmitidas de geração em geração e trazem as questões mais humanas, a sabedoria tradicional e as marcas culturais de diferentes povos. É o que se revela nesta obra por meio de contos de diversos lugares do mundo, recontados pela escrita leve, fluida e bem-humorada de Tatiana Belinky.",
                    Capa = "~/img/28/contos-de-muitos-povos.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 4, // 8–9 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 29,
                    Titulo = "O Lobo e os Sete Cabritinhos",
                    Autor = "Pé da Letra",
                    Descricao = "Uma cabra deixou seus sete filhos sozinhos em casa enquanto procura comida na floresta. Antes de sair, ela alertou sobre o Lobo Mau, que irá tentar entrar na casa.",
                    Capa = "~/img/29/lobo-e-os-sete-cabritinhos.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 1, // 6–7 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 30,
                    Titulo = "Simão e o osso",
                    Autor = "Corey Tabor",
                    Descricao = "Passeando ao redor do lago com seu osso, Simão avista outro cão com um osso melhor e propõe um desafio: quem fizer os truques mais legais, fica com o osso.\r\n\r\nMas ao perceber que o cachorro sabe fazer as mesmas acrobacias que ele, Simão acaba recebendo algo muito melhor do que aquilo que queria: uma lição sobre empatia.\r\n\r\nDo autor vencedor da Medalha Caldecott Corey Tabor, Simão e o osso é uma leitura que vai entreter enquanto ensina sobre generosidade e amizade.",
                    Capa = "~/img/30/simao-e-o-osso1.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 2, // 3–5 anos
                    Destaque = true
                },

            //Livros de Fantasia
                new Livro
                {
                    Id = 31,
                    Titulo = "O Reino das Cores",
                    Autor = " Geizy Reis",
                    Descricao = "E se o mundo fosse todo de uma só cor? Teria a mesma graça e esplendor? O reino das cores é uma história que fala exatamente sobre isso. O livro conta a história de sete reinos, cada um com uma única cor. Porém as cores entram numa disputa para mostrar qual era a mais bonita e importante. No fim, elas descobrem que isso não é o principal e que juntas poderiam criar algo encantador. O enredo tem o intuito de abordar o respeito às diferenças, o diálogo, a união. Conta com uma narrativa simples, na qual cores são usadas para representar as pessoas e seus mundos, além de abordar as cores de forma lúdica e atrativa.",
                    Capa = "~/img/31/o-reino-das-cores.jpg",
                    GeneroId = 4, // Fantasia
                    ClassificacaoIndicativaId = 2, // 3–5 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 32,
                    Titulo = "A Floresta Encantada",
                    Autor = "Elisa De Biase Hopman",
                    Descricao = "Na Floresta Encantada, diferentes animais vivem a sua rotina. A cigarra, o passarinho, o porco-espinho, a formiga, o beija-flor, o macaco, o besouro, o tucano, o pica-pau, a centopeia, as abelhas... e a floresta dá lugar a estas cenas, descritas com leveza pela fonoaudióloga Elisa De Biase Hopman e ilustradas com primor pelo artista Tiago Costa, favorecendo a imaginação e o encanto do pequeno leitor.",
                    Capa = "~/img/32/a-floresta-encantada.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 33,
                    Titulo = "Os dragões de Terrazul",
                    Autor = "Ruth Stiles Gannett",
                    Descricao = "Depois de deixar Elmer em Nuncaverde, o bebê dragão parte em direção a Terrazul, o refúgio dos últimos dragões, ansioso pelo reencontro com sua família. Ao sobrevoar o Deserto Terrível, porém, ele percebe, alarmado, que homens descobriram a região e estão capturando dragões para vendê-los ao zoológico. Mais do que nunca, o bebê dragão precisará da ajuda de seu amigo Elmer para resgatar sua família e salvar Terrazul.\r\n\r\nOs dragões de Terrazul é o último livro da trilogia iniciada com O dragão do meu pai e Elmer o dragão. Com uma combinação perfeita de capítulos curtos e ação constante, a história é ideal para crianças que estão ganhando fluência em leitura e que buscam histórias com textos um pouco mais longos, sem abrir mão de uma leitura leve e prazerosa. É também uma escolha certeira para pais que desejam oferecer aos filhos uma aventura inesquecível para ser lida em voz alta ― do tipo que cativa a atenção de tal maneira que é impossível parar antes da última página.",
                    Capa = "~/img/33/dragoes-de-terrazul1.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 4, // 8–9 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 34,
                    Titulo = "Chorar é como Chover",
                    Autor = "Emília Nuñez",
                    Descricao = "Com ilustrações poéticas e texto emocionante, Chorar é como Chover é uma história para refletir sobre as emoções da infância e a importância de abraçar o que se sente.",
                    Capa = "~/img/34/chorar-e-como-chover1.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 5, // 10–12 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 35,
                    Titulo = "Acreditar",
                    Autor = " Chris Saunders e Emília Nuñez",
                    Descricao = "Um livro para sua criança descobrir o que a torna especial! Preguiça vive uma emocionante jornada de autodescoberta enquanto dá o seu melhor para entender o que o faz único. Com a ajuda de seus amigos, ele descobre que a resposta estava dentro dele otempo todo!",
                    Capa = "~/img/35/acreditar1.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 4, // 8–9 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 36,
                    Titulo = "A Fada do Jardim",
                    Autor = "Fiona Watt",
                    Descricao = "Este livro de adesivos está repleto de fadas para vestir e cenas de um lindo jardim para decorar e vivenciar aventuras divertidas. Com mais de 200 adesivos de roupas, animais e flores para completar as cenas, as crianças vão passar momentos deliciosos decorando o mundo das fadas.",
                    Capa = "~/img/36/fadas-do-jardim.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 2, // 3–5 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 37,
                    Titulo = "Zumbi.net",
                    Autor = " Emília Nuñez",
                    Descricao = "Existe uma lenda urbana que conta de um mundo paralelo no qual as crianças vão parar de tanto exagerar nos games. É o Zumbi.net! Quando Juca encontra Gael congelado na tela do videogame, não tem dúvidas: ele e a sua irmã Cecília vão ter que dar um jeito de entrar no Zumbi.net para resgatar o amigo!",
                    Capa = "~/img/37/zumbi-net1.jpg",
                    GeneroId = 3,
                    ClassificacaoIndicativaId = 3, // 10–12 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 38,
                    Titulo = "Gildo",
                    Autor = " Silvana Rando",
                    Descricao = "Gildo é muito corajoso. Ele gosta de montanha-russa, de avião, de filme de terror e de cantar em público. Mas como quase todo mundo, existe uma coisa que o deixa apavorado... Sempre na noite anterior a alguma festinha de aniversário de um amigo, ele não consegue pregar os olhos, por que será?",
                    Capa = "~/img/38/gildo1.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 39,
                    Titulo = "O Reino do Tempo",
                    Autor = "Isa Colli",
                    Descricao = "Em uma terra distante, os monarcas Solaris e Selíní viviam em harmonia com a natureza, regendo as estações do ano. Com o passar do tempo, porém, eles perceberam que precisavam de ajuda. Quatro crianças mágicas foram, então, preparadas pelo rei e pela rainha para assumir a tarefa de espalhar seus encantos por toda a parte. Desde aqueles dias longínquos, Primavera, Verão, Outono e Inverno, têm a missão de manter o equilíbrio entre si, garantindo a continuidade dessa missão vital para todos os seres do Reino. Cores de pôr-do-sol, cristais brancos e alegrias de fim de tarde aguardam os súditos nessa saga perfumada à natureza.",
                    Capa = "~/img/39/o-reino-do-tempo1.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 5, // 8–9 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 40,
                    Titulo = "Alice no País das Maravilhas (Classic Edition)",
                    Autor = "Lewis Carroll",
                    Descricao = "Uma menina, um coelho e uma história capazes de fazer qualquer um de nós voltar a sonhar. Alice é despertada de um leve sono ao pé de uma árvore por um coelho peculiar. Uma criatura alva e falante com roupas engraçadas, que consulta seu relógio e reclama do próprio atraso. Curiosa como toda criança, Alice segue o animal até cair em um buraco sem fim que mudou para sempre a literatura infantil. Mais de 150 anos depois, Alice no País das Maravilhas continua repleto de ensinamentos para aqueles que ousaram seguir o Coelho Branco até sua toca.",
                    Capa = "~/img/40/alice-no-pais-das-maravilhas1.jpg",
                    GeneroId = 4,
                    ClassificacaoIndicativaId = 5, // 10–12 anos
                    Destaque = true
                },

            //Livros de Poesias Infantis
                new Livro
                {
                    Id = 41,
                    Titulo = "A Arca de Noé",
                    Autor = "Vinícius de Moraes",
                    Descricao = "Crianças e adultos sabem de cor alguns dos poemas infantis de Vinicius de Moraes, graças ao ritmo inteligente e bem-humorado dos seus versos. As deliciosas versões musicais de A arca de Noé são exemplo dessa simpatia que o poeta conquistou entre pequenos e grandes leitores. Os discos A arca de Noé 1 (1980) e A arca de Noé 2 (1981) traziam composições como \"O pato\", \"A casa\", \"O gato\", \"O pingüim\" e \"São Francisco\", que se tornaram famosas nas vozes de Chico Buarque, Milton Nascimento, Toquinho, Marina Lima e Ney Matogrosso, entre outros intérpretes. Agora o livro A arca de Noé ganha nova edição, com todos os 32 poemas da edição original, publicada pela Companhia das Letrinhas pela primeira vez em 1993. Ilustrações assinadas por Nelson Cruz compõem a reedição deste clássico infantil. O poeta Vinicius de Moraes (1913-1980) teve um verdadeiro caso de amor com a música brasileira, tornando-se um de seus maiores letristas. A lista de seus parceiros musicais é vasta e inclui Tom Jobim, Baden Powell, Chico Buarque, Carlos Lyra, Edu Lobo e Toquinho, entre outros.",
                    Capa = "~/img/41/a-arca-de-noe1.jpg",
                    GeneroId = 5, // Poesia Infantil
                    ClassificacaoIndicativaId = 2, // 3–5 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 42,
                    Titulo = "O som do rugido da onça – Vencedor Jabuti 2022",
                    Autor = " Micheliny Verunschk",
                    Descricao = "Em 1817, Spix e Martius desembarcaram no Brasil com a missão de registrar suas impressões sobre o país. Três anos e 10 mil quilômetros depois, os exploradores voltaram a Munique trazendo consigo não apenas um extenso relato da viagem, mas também um menino e uma menina indígenas, que morreriam pouco tempo depois de chegar em solo europeu.\r\nEm seu quinto romance, Micheliny Verunschk constrói uma poderosa narrativa que deixa de lado a historiografia hegemônica para dar protagonismo às crianças ― batizadas aqui de Iñe-e e Juri ― arrancadas de sua terra natal. Entrelaçando a trama do século XIX ao Brasil contemporâneo, somos apresentados também a Josefa, jovem que reconhece as lacunas de seu passado ao ver a imagem de Iñe-e em uma exposição.\r\nCom uma prosa embebida de lirismo, este é um livro sem paralelos na literatura brasileira ao tratar de temas como memória, colonialismo e pertencimento.\r\n\r\n“Um romance que expande as fronteiras da arte literária ao trazer memória, argumentos antropológicos e o melhor que a ficção pode nos oferecer.” ― Itamar Vieira Junior",
                    Capa = "~/img/42/som-do-rugido-da-onca1.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 5, // 6–7 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 43,
                    Titulo = "Cantigas de Roda",
                    Autor = "James Misse e Pé Da Letra",
                    Descricao = "O autor, músico e arte educador james misse, traz neste trabalho um resgate das cantigas de roda como manifestação cultural, desenvolvendo assim a consciência corporal, repertório musical, coordenação motora, socialização e inclusão. Em outras palavras, as cantigas de roda representam uma grande brincadeira com vivencias e descobertas que se transformam em experienciais reais. Esse trabalho conta com as incríveis ilustrações de laura almeida.",
                    Capa = "~/img/43/cantigas-de-roda1.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 2, // 3–5 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 44,
                    Titulo = "Mas que festa!: Nova edição ",
                    Autor = "Ana Maria Machado",
                    Descricao = "Os convites começam a circular: Manuel avisa Frederico, Giovani fala com Beto, Maíra chama Toshiro... De casa em casa, de família em família, a festa de aniversário vai crescendo e ganhando cores, sabores e sotaques.\r\n\r\nNo dia da festa, cada criança chega trazendo um prato preparado em casa e logo a mesa transborda de delícias: cajuzinhos, quibes, pizzas, bolinhos de bacalhau, paellas, pastéis, feijoadas, vatapás, macarronadas e estrogonofes. É fartura garantida!\r\n\r\nNesse clima animado, Ana Maria Machado celebra a diversidade do povo brasileiro. Descendentes de indígenas, africanos, europeus e asiáticos se encontram em uma festa inesquecível, com futebol, música, comilança e muita diversão.",
                    Capa = "~/img/44/mas-que-festa1.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 45,
                    Titulo = "O caso dos ovos",
                    Autor = "Tatiana Belinky",
                    Descricao = "As galinhas estão em greve: não botam mais ovo! Mas a Páscoa vem chegando, e a produção não pode parar...",
                    Capa = "~/img/45/o-caso-dos-ovos1.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 4, // 8–9 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 46,
                    Titulo = "Cantigamente",
                    Autor = "Leo Cunha",
                    Descricao = "Os poemas de Leo Cunha refletem o mundo das crianças e desenvolvem nelas o gosto pela palavra. Os assuntos desses poemas foram retirados do universo infantil, com um olhar sensível e encantador.",
                    Capa = "~/img/46/catigamente1.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 47,
                    Titulo = "Versos Mágicos",
                    Autor = "Van Macedo",
                    Descricao = "No livro \"Versos Mágicos: Livro de Poemas\", cada página é uma aventura poética, onde palavras dançam em harmonia com ilustrações vibrantes. Viaje por paisagens poéticas que inspirarão a criatividade dos pequenos leitores, enquanto personagens cativantes ganham vida através das páginas. Com rimas suaves e ilustrações envolventes, este livro é uma janela para a poesia que encanta corações e estimula mentes curiosas. Prepare-se para uma viagem poética cheia de diversão e aprendizado!",
                    Capa = "~/img/47/versos-magicos1.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 4, // 8–9 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 48,
                    Titulo = "Poemas para Brincar",
                    Autor = "José Paulo Paes",
                    Descricao = "Um clássico da poesia infantil brasileira em que José Paulo Paes propõe a seus leitores brincar com a língua portuguesa. Os poemas apresentam jogos de palavras e até um abecedário com significados inusitados, que diverte, instiga a criatividade das crianças e ainda faz pensar.",
                    Capa = "~/img/48/poemas-para-brincar1.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 2, // 3–5 anos
                    Destaque = true
                },
                new Livro
                {
                    Id = 49,
                    Titulo = "Pequenos Poemas Para Pequenos",
                    Autor = "Eduardo Rodrigues",
                    Descricao = "A natureza, os livros, o tempo, a fome, o medo: tudo é visto com poesia e se transforma em poemas sob o olhar inventivo de Eduardo Rodrigues. Os pequenos poemas, independentes entre si e harmônicos no conjunto que formam, convidam os leitores (não só os pequenos) à graça que as coisas cotidianas têm ou podem ter, se deslocadas da maneira comum como as conhecemos. As ilustrações de Maria Valentina ampliam essa ideia de primeira vez que experimentamos na fruição artística, oferecendo nas poéticas e divertidas criações visuais mais ritmos e melodias para a leitura, a declamação e a escuta dos versos em palavras.",
                    Capa = "~/img/49/pequenos-poemas.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 3, // 6–7 anos
                    Destaque = false
                },
                new Livro
                {
                    Id = 50,
                    Titulo = "Jardins",
                    Autor = "Roseana Murray e Roger Mello",
                    Descricao = "“Neste livro repousam a mais linda poesia e os mais lindos jardins, à espera de que o leitor os penetre com a mais singela delicadeza.”\r\nA obra traz quinze pequenos poemas que representam os mais diversos jardins.\r\nCom muita delicadeza, Roseana Murray mexe com o imaginário do leitor. Cada poema-pintura faz os pequenos descobrirem a poesia que vive ao seu redor, nas pequenas coisas, como nas flores, por exemplo.\r\nA organização dos poemas com as ilustrações do talentoso e premiado Roger Mello imprime qualidade que sensibiliza adultos e crianças. É um verdadeiro presente em formato de livro.",
                    Capa = "~/img/50/jardins1.jpg",
                    GeneroId = 5,
                    ClassificacaoIndicativaId = 5, // 10–12 anos
                    Destaque = false
                }
             );
            modelBuilder.Entity<ImagemLivro>().HasData(
                // Livro 1 - O Menino Maluquinho
                new ImagemLivro { Id = 1, LivroId = 1, CaminhoImagem = "~/img/1/o-menino-maluquinho2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 2 - Maluquinho de família
                new ImagemLivro { Id = 2, LivroId = 2, CaminhoImagem = "~/img/2/maluquinho-de-familia2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 3 - Como Ser Amigo
                new ImagemLivro { Id = 3, LivroId = 3, CaminhoImagem = "~/img/3/como-ser-amigo2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 4 - O Tesouro da Raposa
                new ImagemLivro { Id = 4, LivroId = 4, CaminhoImagem = "~/img/4/o-tesouro-da-raposa2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 5 - A cesta da dona Maricota
                new ImagemLivro { Id = 5, LivroId = 5, CaminhoImagem = "~/img/5/a-cesta-da-dona-maricota2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 6, LivroId = 5, CaminhoImagem = "~/img/5/a-cesta-da-dona-maricota3.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 6 - A ursinha que não dormia sozinha
                new ImagemLivro { Id = 7, LivroId = 6, CaminhoImagem = "~/img/6/a-ursinha-que-nao-dormia-sozinha2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 8, LivroId = 6, CaminhoImagem = "~/img/6/a-ursinha-que-nao-dormia-sozinha3.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 7 - Coraline
                new ImagemLivro { Id = 9, LivroId = 7, CaminhoImagem = "~/img/7/coraline2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 10, LivroId = 7, CaminhoImagem = "~/img/7/coraline3.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 8 - As aventuras de Nino
                new ImagemLivro { Id = 11, LivroId = 8, CaminhoImagem = "~/img/8/as-aventuras-de-nino2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 9 - Menina bonita do laço de fita
                new ImagemLivro { Id = 12, LivroId = 9, CaminhoImagem = "~/img/9/menina-bonita-do-laco-de-fita2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 13, LivroId = 9, CaminhoImagem = "~/img/9/menina-bonita-do-laco-de-fita3.jpg", DescricaoFoto = "Foto adicional   " },
                new ImagemLivro { Id = 14, LivroId = 9, CaminhoImagem = "~/img/9/menina-bonita-do-laco-de-fita4.jpg", DescricaoFoto  = "Foto adicional" },

                // Livro 12 - O pedido da fada madrinha
                new ImagemLivro { Id = 15, LivroId = 12, CaminhoImagem = "~/img/12/o-pedido-da-fada-madrinha2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 16, LivroId = 12, CaminhoImagem = "~/img/12/o-pedido-da-fada-madrinha3.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 17, LivroId = 12, CaminhoImagem = "~/img/12/o-pedido-da-fada-madrinha4.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 13 - Chapeuzinho Vermelho
                new ImagemLivro { Id = 18, LivroId = 13, CaminhoImagem = "~/img/13/chapeuzinho-vermelho2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 19, LivroId = 13, CaminhoImagem = "~/img/13/chapeuzinho-vermelho3.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 15 - A primavera da largarta
                new ImagemLivro { Id = 20, LivroId = 15, CaminhoImagem = "~/img/15/a-primaveira-da-lagarta2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 16 - João e o pé de feijão
                new ImagemLivro { Id = 21, LivroId = 16, CaminhoImagem = "~/img/16/joao-e-o-pe-de-feijao2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 22, LivroId = 16, CaminhoImagem = "~/img/16/joao-e-o-pe-de-feijao3.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 23, LivroId = 16, CaminhoImagem = "~/img/16/joao-e-o-pe-de-feijao4.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 17 - Os três porquinhos
                new ImagemLivro { Id = 24, LivroId = 17, CaminhoImagem = "~/img/17/os-tres-porquinhos2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 25, LivroId = 17, CaminhoImagem = "~/img/17/os-tres-porquinhos3.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 26, LivroId = 17, CaminhoImagem = "~/img/17/os-tres-porquinhos4.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 18 - O pequenho príncipe
                new ImagemLivro { Id = 27, LivroId = 18, CaminhoImagem = "~/img/18/o-pequeno-principe2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 28, LivroId = 18, CaminhoImagem = "~/img/18/o-pequeno-principe3.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 19 - O patinho feio
                new ImagemLivro { Id = 29, LivroId = 19, CaminhoImagem = "~/img/19/o-patinho-feio2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 21 - A cigarra e a formiga
                new ImagemLivro { Id = 30, LivroId = 21, CaminhoImagem = "~/img/21/a-cigarra-e-a-formiga2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 23 - A lebre e a tartaruga
                new ImagemLivro { Id = 31, LivroId = 23, CaminhoImagem = "~/img/23/a-lebre-e-a-tartaruga2.jpg", DescricaoFoto = "Foto adicional " },
                new ImagemLivro { Id = 32, LivroId = 23, CaminhoImagem = "~/img/23/a-lebre-e-a-tartaruga3.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 24 - Fabulas de Esopo
                new ImagemLivro { Id = 33, LivroId = 24, CaminhoImagem = "~/img/24/fabulas-de-escopo2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 25 - Perigoso contem coelhos
                new ImagemLivro { Id = 34, LivroId = 25, CaminhoImagem = "~/img/25/perigoso-contem-coelhos2.jpg", DescricaoFoto = "Foto adicional" },
                 new ImagemLivro { Id = 35, LivroId = 25, CaminhoImagem = "~/img/25/perigoso-contem-coelhos3.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 27 - A raposa e as uvas
                new ImagemLivro { Id = 36, LivroId = 27, CaminhoImagem = "~/img/27/a-raposa-e-as-uvas2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 30 - Simão e o osso
                new ImagemLivro { Id = 37, LivroId = 30, CaminhoImagem = "~/img/30/simao-e-o-osso2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 38, LivroId = 30, CaminhoImagem = "~/img/30/simao-e-o-osso3.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 33 - Dragões de Terrazul
                new ImagemLivro { Id = 39, LivroId = 33, CaminhoImagem = "~/img/33/dragoes-de-terrazul2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 40, LivroId = 33, CaminhoImagem = "~/img/33/dragoes-de-terrazul3.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 41, LivroId = 33, CaminhoImagem = "~/img/33/dragoes-de-terrazul4.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 34 - Chorar é como Chover
                new ImagemLivro { Id = 42, LivroId = 34, CaminhoImagem = "~/img/34/chorar-e-como-chover2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 43, LivroId = 34, CaminhoImagem = "~/img/34/chorar-e-como-chover3.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 44, LivroId = 34, CaminhoImagem = "~/img/34/chorar-e-como-chover4.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 35 - Acreditar
                new ImagemLivro { Id = 45, LivroId = 35, CaminhoImagem = "~/img/35/maluquinho-de-familia2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 46, LivroId = 35, CaminhoImagem = "~/img/35/maluquinho-de-familia3.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 47, LivroId = 35, CaminhoImagem = "~/img/35/maluquinho-de-familia4.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 37 - Zumbi.net
                new ImagemLivro { Id = 48, LivroId = 37, CaminhoImagem = "~/img/37/zumbi-net2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 49, LivroId = 37, CaminhoImagem = "~/img/37/zumbi-net3.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 38 - Gildo
                new ImagemLivro { Id = 50, LivroId = 38, CaminhoImagem = "~/img/38/gildo2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 39 - O reino do tempo
                new ImagemLivro { Id = 51, LivroId = 39, CaminhoImagem = "~/img/39/o-reino-do-tempo2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 40 - Alice no País das Maravilhas
                new ImagemLivro { Id = 52, LivroId = 40, CaminhoImagem = "~/img/40/alice-no-pais-das-maravilhas2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 53, LivroId = 40, CaminhoImagem = "~/img/40/alice-no-pais-das-maravilhas3.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 54, LivroId = 40, CaminhoImagem = "~/img/40/alice-no-pais-das-maravilhas4.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 41 - A arca de noe
                new ImagemLivro { Id = 55, LivroId = 41, CaminhoImagem = "~/img/41/a-arca-de-noe2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 42 - O som do rugido da onça
                new ImagemLivro { Id = 56, LivroId = 42, CaminhoImagem = "~/img/42/som-do-rugido-da-onca2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 57, LivroId = 42, CaminhoImagem = "~/img/42/som-do-rugido-da-onca3.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 58, LivroId = 42, CaminhoImagem = "~/img/42/som-do-rugido-da-onca4.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 43 - Cantigas de roda
                new ImagemLivro { Id = 59, LivroId = 43, CaminhoImagem = "~/img/43/cantigas-de-roda3.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 44 - Mas que festa
                new ImagemLivro { Id = 60, LivroId = 44, CaminhoImagem = "~/img/44/mas-que-festa2.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 61, LivroId = 44, CaminhoImagem = "~/img/44/mas-que-festa3.jpg", DescricaoFoto = "Foto adicional" },
                new ImagemLivro { Id = 62, LivroId = 44, CaminhoImagem = "~/img/44/mas-que-festa4.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 45 - O caso dos ovos
                new ImagemLivro { Id = 63, LivroId = 45, CaminhoImagem = "~/img/45/o-caso-dos-ovos2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 46 - Catigamamente
                new ImagemLivro { Id = 64, LivroId = 46, CaminhoImagem = "~/img/46/catigamente2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 47 - Versos mágicos
                new ImagemLivro { Id = 65, LivroId = 47, CaminhoImagem = "~/img/47/versos-magicos2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 48 - Poemas para brincar
                new ImagemLivro { Id = 66, LivroId = 48, CaminhoImagem = "~/img/48/poemas-para-brincar2.jpg", DescricaoFoto = "Foto adicional" },

                // Livro 50 - Maluquinho de família
                new ImagemLivro { Id = 67, LivroId = 50, CaminhoImagem = "~/img/50/jardins2.jpg", DescricaoFoto = "Foto adicional" }
            );
        }
    }
}
