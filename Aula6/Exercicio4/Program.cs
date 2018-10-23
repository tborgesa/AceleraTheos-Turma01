using System;

namespace Exercicio4
{
    class Program
    {
        static int _votosHaddad = 0;
        static int _votosBolsonaro = 0;
        static int _votosBracos = 0;
        static int _votosNulos = 0;

        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                string mensagem = @"Escolha umas das opções abaixo:
                                        01 - Votar
                                        02 - Ver resultado
                                        03 - Sair do sistema";

                Console.Clear();
                Console.WriteLine(mensagem);

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Votar();
                        break;
                    case 2:
                        Resultado();
                        break;
                    case 3:
                        sair = true;
                        Console.WriteLine("Você escolheu sair do sistema.");
                        break;
                    default:
                        break;
                }

                Console.ReadKey();
            }
            
        }

        private static void Resultado()
        {
            //resultado por percentual
            int total = _votosBolsonaro + _votosHaddad + _votosBracos + _votosNulos;
            int validos = _votosBolsonaro + _votosHaddad;


            if(validos == 0)
            {
                Console.WriteLine("Não houve votos validos!");
                Console.ReadKey();
                return;
            }

            int votosHaddad = (_votosHaddad / validos) * 100;
            int votosBolsonaro = (_votosBolsonaro / validos) * 100;

            Console.WriteLine($"Total de votos: {total}");
            Console.WriteLine($"Total de votos validos: {validos}");
            Console.WriteLine($"Total de votos Haddad: {votosHaddad:N2}%");
            Console.WriteLine($"Total de votos Bolsonaro: {votosBolsonaro:N2}%");

        }

        private static void Votar()
        {
            string mensagem = @"Escolha umas das opções abaixo:
                                        13 - Haddad
                                        17 - Bolsonaro
                                        00 - Brancos";

            Console.Clear();
            Console.WriteLine(mensagem);


            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 13:
                    _votosHaddad++;
                    break;
                case 17:
                    _votosBolsonaro++;
                    break;
                case 00:
                    _votosBracos++;
                    break;
                default:
                    _votosNulos++;
                    break;
            }

        }
    }
}
