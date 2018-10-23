using System;

/*4. Faça um sistema de pesquisa eleitoral para presidente no segundo turno.Requisitos: 1. O usuário pode escolher 13 - Haddad / 17- Bolsonaro / 00 - Brancos  2. Qualquer outra escolha anulará o voto na pesquisa 3. O usuário poderá ter a escolha de votar quantas vezes ele quiser (simulando várias pessoas votando) ou ver o resultado ou sair; 4. O resultado deverá conter Votos Totais, Votos Válidos (Votos excluindos os brancos e nulos). %  de votos no Haddad e % de votos do Bolsonaro. 5. Depois de ver o resultado o usuário poderá voltar para a "urna" e continuar votando ou sair do
  sistema.
 */

namespace Exercicio04
{
    class Program
    {
        static string _mensagemInvalido = "Entrada inválida, execute o sistema e tente novamente!";
        static int entrada, cont13, cont17, branco;

        static void Main(string[] args)
        {
            int cont = -1;
            bool check = true;

            while (check)
            {

                while (check)
                {
                    Console.Clear();

                    Console.WriteLine(@"
        Eleicoes:
        13 - Haddad
        17- Bolsonaro
        00 - Brancos 

        01 - Verificar votos
                    ");

                    var put = Console.ReadLine();

                    if (!int.TryParse(put, out entrada))
                    {
                        Console.WriteLine(_mensagemInvalido);
                        Console.ReadKey();
                        continue;
                    }

                    switch (entrada)
                    {
                        case 13:
                            cont13++;
                            break;
                        case 17:
                            cont17++;
                            break;
                        case 00:
                            branco++;
                            break;
                        case 1:
                            if (cont == -1)
                            {
                                return;
                            }
                            check = false;
                            break;
                        default:
                            Console.WriteLine("Voto Anulado");
                            Console.ReadKey();
                            break;
                    }
                    cont++;
                }

                Console.Clear();

                Console.WriteLine("Total de Votos:");
                Console.WriteLine($"Quantidade Hadadd: {cont13}");
                Console.WriteLine($"Quantidade Bolsonaro: {cont17}");
                Console.WriteLine($"Quantidade em Branco: {branco}");
                Console.WriteLine($"Quantidade de Votos: {cont}");

                var total = cont13 + cont17;

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Percentual dos candidatos:");
                Console.WriteLine($"Quantidade Hadadd: {Math.Round((((double)cont13 / (double)total) * 100.00),2)}%");
                Console.WriteLine($"Quantidade Bolsonaro: {Math.Round(((double)(cont17 / (double)total) * 100.00),2)}%");
                Console.WriteLine($"Quantidade de Votos: {total}");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Deseja retormar os votos (0) Sim ou (1) Nao?");
                int conf = int.Parse(Console.ReadLine());

                if (conf == 1)
                {
                    check = false;
                }
                else if (conf == 0)
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine(_mensagemInvalido);
                }

                Console.Clear();

                cont--;

            }
        }
    }
}