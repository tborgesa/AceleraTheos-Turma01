using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um sistema de pesquisa eleitoral para presidente no segundo turno.
            //Requisitos:
            //1.O usuário pode escolher 13 - Haddad / 17 - Bolsonaro / 00 - Brancos
            //2.Qualquer outra escolha anulará o voto na pesquisa
            //3.O usuário poderá ter a escolha de votar quantas vezes ele quiser(simulando várias pessoas votando) ou ver o resultado ou sair;
            //4.O resultado deverá conter Votos Totais, Votos Válidos(Votos excluindos os brancos e nulos). % de votos no Haddad e % de votos do Bolsonaro.
            //5.Depois de ver o resultado o usuário poderá voltar para a "urna" e continuar votando ou sair do sistema.


            double haddad = 0, bolso = 0, branco = 0, nulo = 0; 

            var _mensagem = "Açao invalida";
            var menu = "Escolha a açao \n1- Votar \n2- Ver resultado \n3 - Sair";
            var candidatos = "13- Haddad  \n17- Bolsonaro  \n00- branco";
            double escolha = 0;

            Console.WriteLine(menu);
            escolha = Convert.ToInt32(Console.ReadLine());

            bool saiu = false;
            while (!saiu)
            {

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine(candidatos);
                        int voto = Convert.ToInt32(Console.ReadLine());
                        if (voto == 17)
                            bolso++;
                        else if (voto == 13)
                            haddad++;
                        else if (voto == 00)
                            branco++;
                        else
                            nulo++;
                        Console.Clear();
                        Console.WriteLine(menu);
                        escolha = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        double votosTotais = (haddad + bolso + branco + nulo), votosValidos = (haddad + bolso);
                        double porcHa = (haddad / votosValidos) * 100;
                        double porcBo = (bolso / votosValidos) * 100;
                        Console.WriteLine($"Bolso tem {porcBo:n2}% \nHaddad tem {porcHa:n2}%");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(menu);
                        Console.ReadKey();
                        escolha = Convert.ToInt32(Console.ReadLine());
                        break;
                        
                    case 3:
                        Console.WriteLine("vc saiu");
                        Console.ReadKey();
                        saiu = true; 
                        continue;
                }


            }

            Console.ReadKey();
        }
    }
}
