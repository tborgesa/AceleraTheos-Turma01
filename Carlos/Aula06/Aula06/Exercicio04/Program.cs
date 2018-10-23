using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4. Faça um sistema de pesquisa eleitoral para presidente no segundo turno.
                  Requisitos:
                  1. O usuário pode escolher 13 - Haddad / 17- Bolsonaro / 00 - Brancos 
                  2. Qualquer outra escolha anulará o voto na pesquisa
                  
                     3. O usuário poderá ter a escolha de votar quantas vezes ele quiser (simulando várias pessoas votando) ou ver o resultado ou sair;
                  4. O resultado deverá conter Votos Totais, Votos Válidos (Votos excluindos os brancos e nulos). % de votos no Haddad e % de votos do Bolsonaro.
                  
                  5. Depois de ver o resultado o usuário poderá voltar para a "urna" e continuar votando ou sair do sistema. */

            Votar();

            Console.ReadKey();

        }

        private static void Votar()
        {
            int votoHaddad = 0;
            int votoBolsonaro = 0;
            int votoBranco = 0;

            bool saiu = false;

            while (!saiu)
            {

                string _menuOpcaoVoto =
@"Pesquisa eleitoral para presidente, escolha uma das opções abaixo:
13 - Haddad
17 - Bolsonaro
00 - Brancos
1 - VER RESULTADO
2 - SAIR";
                string _mensagemInvalida = "Entrada inválida, aperte qualquer tecla e tentar novamente!";

                Console.Clear();

                Console.WriteLine($"{_menuOpcaoVoto}");
                string voto = Console.ReadLine();

                if (!int.TryParse(voto, out var numero))
                {
                    Console.WriteLine(_mensagemInvalida);

                    return;
                }

                switch (numero)
                {
                    case 13:

                        votoHaddad += 1;

                        Console.WriteLine($"Você votou 13 Haddad! Aperte qualquer tecla para votar novamente.");                        

                        Console.ReadKey();

                        break;

                    case 17:

                        votoBolsonaro += 1;

                        Console.WriteLine($"Você votou 14 Bolsonaro! Aperte qualquer tecla para votar novamente.");                        

                        Console.ReadKey();

                        break;

                    case 00:

                        votoBranco += 1;

                        Console.WriteLine($"Você votou em branco! Aperte qualquer tecla para votar novamente.");

                        Console.ReadKey();

                        break;

                    case 1:
                            
                        double totalVoto = votoHaddad + votoBolsonaro + votoBranco;
                        double totalVotoValido = votoHaddad + votoBolsonaro;
                        double percentualHaddad = (votoHaddad / totalVotoValido) * 100;
                        double percentualBolsonaro = (votoBolsonaro / totalVotoValido) * 100;

                        Console.WriteLine($"\n\nResultado da votação");

                        Console.WriteLine($"\nTotal de votos: {totalVoto}");
                        Console.WriteLine($"\nTotal de votos válidos: {totalVotoValido}");
                        Console.WriteLine($"\nTotal de votos em branco: {votoBranco}");
                                               
                        Console.WriteLine($"\n13 - Haddad - quantidade de votos: {votoHaddad}");
                        Console.WriteLine($"\n13 - Haddad - percentual de votos: {percentualHaddad}%");

                        Console.WriteLine($"\n17 - Bolsonaro - quantidade de votos: {votoBolsonaro}");
                        Console.WriteLine($"\n17 - Bolsonaro - percentual de votos: {percentualBolsonaro}%");

                        Console.WriteLine($"\n\nAperte qualquer tecla para votar novamente.");

                        Console.ReadKey();

                        break;

                    case 2:
                        Console.WriteLine("Você saiu! Aperte qualquer tecla para fechar o sistema.");
                        saiu = true;
                        break;


                    default:
                        Console.WriteLine(_mensagemInvalida);
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
