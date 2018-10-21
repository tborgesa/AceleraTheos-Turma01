using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna05
{
    class Program
    {

        static string _mensagemInvalido = "Entrada inválida, execute o sistema e tente novamente!";
        static void Main(string[] args)
        {
            Urna05();
            Console.ReadKey();
        }

        private static void Urna05()
        {
            int votosHaddad = 0;
            int votosBolsonaro = 0;
            int votosBrancos = 0;
            int votosNulos = 0;
            int votosTotal = votosHaddad + votosBolsonaro + votosBrancos;
            int votosValidos = votosTotal - (votosBrancos + votosNulos);

            bool saiu = false;
            while (!saiu)
            {
                Console.Clear();
                string menu = @"Escolha uma das opções
01 - Digite 1 para votar
02 - Digite 2 para ver resultados
03 - Digite 3 para sair";
                Console.WriteLine(menu);

                string numeroDigitado = Console.ReadLine();
                if (!int.TryParse(numeroDigitado, out var numero))
                {
                    Console.WriteLine(_mensagemInvalido);
                    return;
                }

                switch (numero)
                {
                    case 1:
                        Console.WriteLine(@"Escolha uma opção para votar: 
13 - Haddad
17 - Bolsonaro
00 - Brancos
Atenção: qualquer escolha diferente das opções acima será considerada nulo");

                        string voto = Console.ReadLine();

                        if (voto == "13")
                            votosHaddad += 1;
                        else if (voto == "17")
                            votosBolsonaro += 1;
                        else if (voto == "00")
                            votosBrancos += 1;
                        else
                            votosNulos += 1;
                        break;

                    case 2:
                        string apuracao = $@"Votos totais: {votosTotal}
Votos brancos: {votosBrancos}
Votos nulos: {votosNulos}
Votos Haddad: {(votosHaddad + votosTotal) * 100}%
Votos Bolsonado: {(votosBolsonaro + votosTotal) * 100}%";

                        Console.WriteLine("Resultado da apuração eleições 2018");
                        Console.WriteLine(apuracao);
                        Console.WriteLine("Digite 1 para votar novamente ou qualquer tecla para sair");
                        string fim = Console.ReadLine();

                        if (fim == "1")
                            goto case 1;
                        else
                            Console.WriteLine("Saindo da votação!");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu sair");
                        Console.ReadKey();
                        break;
                }

            }
        }
    }
}
