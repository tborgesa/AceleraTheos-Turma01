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

            //todo thiago: essas duas variaveis devem ser calculadas toda vez que quiser apurar os votos
            //ja que se no momento que vc esta somando aqui é tudo zerado.
            //lembre -se que os votos totais tambem compreendem os nulos
            int votosTotal = votosHaddad + votosBolsonaro + votosBrancos;
            int votosValidos = votosTotal - (votosBrancos + votosNulos);

            //todo thiago: em nenhum momento vc coloca essa variavel como true. o sistema nunca sera fechado.
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

                        //todo thiago: esse passo de pedir essa opção para o usuário nao precisa
                        //deixe apenas o break e volta para o menu inicial e o usuário escolhe novamente. que nem vc fez na opção 1.
                        Console.WriteLine("Digite 1 para votar novamente ou qualquer tecla para sair");
                        string fim = Console.ReadLine();

                        if (fim == "1")
                            //todo thiago: nunca use goto.... repito nunca use goto.... ele serve para linguagem procedural
                            //é totalmente desaconselhado em linguagens orientada a objeto.
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
