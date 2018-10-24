using System;

namespace Exercicios
{
    class Program
    {
        static int _votosHaddad = 0;
        static int _votosBolsonaro = 0;
        static int _votosBrancos = 0;
        static int _votosNulos = 0;

        static void Main(string[] args)
        {
            //Exercicio 04 (Votação) feito pelo Thiago

            while (true)
            {
                int opcao = MenuPrincipal();
                switch (opcao)
                {
                    case 1:
                        Votar();
                        break;

                    case 2:
                        Console.Clear();
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
                if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao > 3 || opcao < 1)
                {
                    Console.WriteLine("Digite uma opção válida!");
                    Console.ReadKey();
                }
                else
                    return opcao;
            }
        }

        private static void Votar()
        {
            string menu = @"PESQUISA PARA PRESIDENTE SEGUNDO TURNO
Escola uma das opções:
13 - Haddad;
17 - Bolsonaro;
00 - Branco
";
            Console.Clear();
            Console.WriteLine(menu);

            string opcao = Console.ReadLine();

            if (int.TryParse(opcao, out int numero))
            {
                switch (numero)
                {
                    case 13:
                        //haddad
                        _votosHaddad++;
                        break;
                    case 17:
                        //bolsonaro
                        _votosBolsonaro++;
                        break;
                    case 0:
                        //branco
                        _votosBrancos++;
                        break;
                    default:
                        //nulo
                        _votosNulos++;
                        break;
                }
            }
            else
                //nulo
                _votosNulos++;
        }

        private static void MostrarResultado()
        {
            int total = _votosNulos + _votosHaddad + _votosBolsonaro + _votosBrancos;
            int validos = _votosHaddad + _votosBolsonaro;
            double votosHaddad = ((double)_votosHaddad / validos) * 100;
            double votosBolsonaro = ((double)_votosBolsonaro / validos) * 100;

            if (validos == 0)
            {
                Console.WriteLine("Não houve votos.");
                Console.ReadKey();
            }
            Console.WriteLine($"RESULTADO:");
            Console.WriteLine($"Votos Totais: {total}.");
            Console.WriteLine($"Votos Válidos: {validos}.");
            Console.WriteLine();
            Console.WriteLine($"13 - HADDAD: {votosHaddad:n2}% - ({_votosHaddad}).");
            Console.WriteLine($"17 - BOLSONARO: {votosBolsonaro:n2}% - ({_votosBolsonaro}).");
            Console.ReadKey();
        }
    }
}
