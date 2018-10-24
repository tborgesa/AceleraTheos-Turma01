using System;

namespace Exercicio04
{
    class Program
    {
        static int _votosHaddad = 0;
        static int _votosBolsonaro = 0;
        static int _votosBranco = 0;
        static int _votosNulo = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                int opcao = MenuPrincipal();
                switch (opcao)
                {
                    case 1:
                        Votar();
                        break;
                    case 2:
                        MostrarResultado();
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu sair!");
                        Console.ReadKey();
                        return;
                    default:
                        break;
                }
            }
        }

        private static int MenuPrincipal()
        {
            while (true)
            {
                string menu = @"PESQUISA PARA PRESIDENTE SEGUNDO TURNO
Escolha uma das opções:
01 - Votar
02 - Ver Resultado
03 - Sair";

                Console.Clear();
                Console.WriteLine(menu);

                if (int.TryParse(Console.ReadLine(), out int opcao) && opcao >= 1 && opcao <= 3)
                    return opcao;
                else
                {
                    Console.WriteLine("Digite uma opção valida!");
                    Console.ReadKey();
                }

            }
        }

        private static void Votar()
        {
            string menu = @"PESQUISA PARA PRESIDENTE SEGUNDO TURNO
Escolha uma das opções:
13 - Haddad
17 - Bolsonaro
00 - Brancos";

            Console.Clear();
            Console.WriteLine(menu);

            string opcao = Console.ReadLine();

            if (int.TryParse(opcao, out int numero))
            {
                switch (numero)
                {
                    case 13:
                        _votosHaddad++;
                        break;
                    case 17:
                        _votosBolsonaro++;
                        break;
                    case 00:
                        _votosBranco++;
                        break;
                    default:
                        _votosNulo++;
                        break;
                }
            }
            else
                _votosNulo++;
        }

        private static void MostrarResultado()
        {
            int total = _votosHaddad + _votosBolsonaro + _votosBranco + _votosNulo;
            int validos = _votosHaddad + _votosBolsonaro;

            if (validos == 0)
            {
                Console.WriteLine("Não houve votos, por isso não existe apuração");
                Console.ReadKey();
                return;
            }

            double fatiaHaddad = ((double)_votosHaddad / (double)validos) * 100;
            double fatiaBolsonaro = ((double)_votosBolsonaro / (double)validos) * 100;

            Console.WriteLine("RESULTADO:");
            Console.WriteLine($"Votos Totais: {total}.");
            Console.WriteLine($"Votos Válidos: {validos}.");
            Console.WriteLine();
            Console.WriteLine($"13 - HADDAD: {fatiaHaddad:N2} % ({_votosHaddad})");
            Console.WriteLine($"17 - BOLSONARO: {fatiaBolsonaro:N2} % ({_votosBolsonaro})");
            Console.ReadKey();
        }
    }
}
