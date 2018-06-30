using System;
using System.Collections.Generic;

namespace TheBestSeries.Models
{
    public class ListMovie
    {
        public List<Series> Filmes { get; set; }
        public ListMovie()
        {
            this.Filmes = new List<Series>
            {
                new Series
                {
                    Nome = "Breaking Bad", 
                    Image = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/3csuqXU5DX98hsspUp6MwNICzLe.jpg",
                    Sinopse = "Walter White é um professor de química que leva uma vida difícil e luta para pagar as contas, " +
                              "sustentando a esposa e o filho. Sua vida inteira muda diante de um diagnóstico perturbador; " +
                              "câncer do pulmão sem possibilidade de cura. Com poucos anos de vida e nada mais a perder," +
                              " Walter usa seus conhecimentos de química para fazer e vender metanfetamina com um dos " +
                              "seus ex-alunos. Seus negócios crescem e as mentiras também, mas nada detém Walter em sua" +
                              " missão de assegurar o futuro da família após a sua morte, mesmo que ele tenha que arriscar a vida da família toda."
                },
                new Series 
                { 
                    Nome = "Luke Cage", 
                    Image = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/9nWZZ1ghE0LuXEWJi7QjCymHygi.jpg",
                    Sinopse = "Luke Cage é um ex-membro de gangue que foi preso acusado de um crime que não cometeu." +
                              " Um experimento sabotado deu a ele super-força e resistência," +
                              " e ele escapa da prisão para se tornar um super-herói de aluguel." +
                              " Mike Colter interpretará Luke Cage, um homem com super-força e pele" +
                              " impenetrável que agora luta contra o crime. Mahershala Ali será Cornell Stokes, " +
                              "Alfre Woodard será a Mariah Dillard, Simone Missick será a Misty Knight, " +
                              "Theo Rossi como Shades, e Frank Whaley será Rafael Scarfe que também fazem parte do elenco."
                },
                new Series
                {
                    Nome = "Jessica Jones", 
                    Image = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/8a7e2GNpMnjI2hgRZH3jq2c7ffv.jpg",
                    Sinopse = "Desde que sua curta vida como super-heroína acabou de forma trágica," +
                              " Jessica Jones (Krysten Ritter) vem reconstruindo sua carreira e passou" +
                              " a levar a vida como detetive particular no bairro de Hell's Kitchen, " +
                              "em Nova York, na sua própria agência de investigações, a Alias Investigations." +
                              " Traumatizada por eventos anteriores de sua vida, ela sofre de Transtorno de Estresse" +
                              " Pós-Traumático, e tenta fazer com que seus super-poderes passem despercebidos pelos seus" +
                              " clientes. Mas, mesmo tentando fugir do passado, seus demônios particulares vão voltar a" +
                              " perseguí-la, na figura de Zebediah Kilgrave (David Tennant), um obsessivo vilão que fará " +
                              "de tudo para chamar a atenção de Jessica."

                    
                },
                new Series
                {
                    Nome = "Punho de Ferro", 
                    Image = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/7uCpMX3ktMdztlezDBRiMstmapC.jpg",
                    Sinopse = "Quinze anos depois de ter sido dado como morto, Danny Rand ressurge. Com a força do Punho de Ferro, ele espera recuperar seu passado e cumprir seu destino."
                },
                new Series
                {
                    Nome = "Demolidor", 
                    Image = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/uEegaFm94rrXrJIZSxkrWBybfaS.jpg",
                    Sinopse = "Adaptação de HQ da Marvel, a história apresenta Matt Murdock (Charlie Cox, de Boardwalk Empire), um advogado que, ao ser exposto a resíduos radioativos, perde a visão. Anos mais tarde, vingando a morte do pai, ele assume a identidade de Demolidor, um herói que tem sentidos super aguçados."
                },
                new Series
                {
                    Nome = "Punisher", 
                    Image = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/ddiQriqWxnEDhy4ufjc18HDI98.jpg",
                    Sinopse = "O ex-marine Frank Castle só quer punir os criminosos responsáveis pela morte da sua família, mas torna-se alvo de uma conspiração militar."
                }

            };
        }
    }
}
