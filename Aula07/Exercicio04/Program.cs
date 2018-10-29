using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 4) Os coelhos se reproduzem todo mês.
Considerando que cada par produz exatamente um par de filhotes cada mês, e cada par de filhotes torna-se fértil depois de exatamente um mês.
Solicite ao usuário quantos pares existem inicialmente e quantos pares ele deseja ter.
Calcule para ele quantos meses são necessários para chegar na quantidade de par de coelho desejado.
OBS: Considere que todos os coelhos iniciais já estão fertil.
*/

namespace Exercicio04
{
    class Program
    {
        static int coelhosFerteis, mes = 1;
        static int temp, filhotes, total, desejado = 0;
        static string _mensagemInvalida = "Registro invalido!!!";

        static void Main(string[] args)
        {
            telaMenu();

            casoBase();

            while (true)
            {
                confere();

                visualiza();

                logica();
            }
        }

        private static void telaMenu()
        {
            Console.WriteLine($"Digite valor desjado dos pares:");
            desejado = int.Parse(Console.ReadLine());
        }

        private static void casoBase()
        {
            if (desejado == 0)
            {
                Console.WriteLine("Invalido");
            }

            else if (desejado == 1)
            {
                visualiza();
                Console.ReadKey();
                return;
            }
        }

        private static void teste()
        {
            if (coelhosFerteis+temp == 13 && mes == 6)
            {
                Console.WriteLine("Deu certo");
                Console.ReadKey();
            }
        }

        private static void logica()
        {
            temp = filhotes;

            filhotes = coelhosFerteis;

            coelhosFerteis += temp;

            mes++;
        }

        private static void confere()
        {
            total = coelhosFerteis + filhotes;

            if (total >= desejado)
            {
                visualiza();
                Console.ReadKey();
                return;
            }
        }

        private static void visualiza()
        {
            Console.WriteLine($"Quantidade de coelhos ferteis  : {coelhosFerteis}");
            Console.WriteLine($"Quantidade de coelhos filhotes : {filhotes}");
            Console.WriteLine($"Quantidade de mes(s){mes}");
            Console.WriteLine();
        }



    }
}
