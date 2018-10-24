using System;

namespace Urna05
{
    class Program
    {

        static int _votosHaddad = 0;
        static int _votosBolsonaro = 0;
        static int _votosBrancos = 0;
        static int _votosNulos = 0;


        static string _mensagemInvalido = "Entrada inválida, execute o sistema e tente novamente!";

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
                        Apuracao();
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu sair");
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
                string menu = @"Escolha uma das opções
01 - Digite 1 para votar
02 - Digite 2 para ver resultados
03 - Digite 3 para sair";

                Console.Clear();
                Console.WriteLine(menu);

                if (int.TryParse(Console.ReadLine(), out int opcaoMenu) && opcaoMenu >= 1 && opcaoMenu <= 3)
                {
                    return opcaoMenu;
                }
                else
                {
                    Console.WriteLine(_mensagemInvalido);
                    Console.ReadKey();
                }

                return opcaoMenu;

            }

        }

        private static void Votar()
        {
            Console.Clear();
            Console.WriteLine(@"Escolha uma opção para votar: 
 13 - Haddad
 17 - Bolsonaro
 00 - Brancos
 Atenção: qualquer escolha diferente das opções acima será considerada nulo");

            string voto = Console.ReadLine();

            if (voto == "13")
                _votosHaddad += 1;
            else if (voto == "17")
                _votosBolsonaro += 1;
            else if (voto == "00")
                _votosBrancos += 1;
            else
                _votosNulos += 1;
        }

        private static void Apuracao()
        {
            int votosTotal = _votosHaddad + _votosBolsonaro + _votosNulos + _votosBrancos;
            int votosValidos = _votosHaddad + _votosBolsonaro;

            if (votosValidos == 0)
            {
                Console.WriteLine("Sem apuração pois não houve votos");
                Console.ReadKey();
                return;
            }

            double resultadoHaddad = ((double)_votosHaddad / (double)votosValidos) * 100;
            double resultadoBolsonaro = ((double)_votosBolsonaro / (double)votosValidos) * 100;
            string apuracao = $@" Votos totais: {votosTotal}
 Votos brancos: {_votosBrancos} 
 Votos nulos: {_votosNulos}
 Votos Haddad: {resultadoHaddad:N2}% ({_votosHaddad})
 Votos Bolsonado: {resultadoBolsonaro:N2}% ({_votosBolsonaro})";

            Console.WriteLine("Resultado da apuração eleições 2018");
            Console.WriteLine(apuracao);
            Console.ReadKey();
        }

    }
}
