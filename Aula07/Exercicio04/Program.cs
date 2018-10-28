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
            //4) Os coelhos se reproduzem todo mês.
            //Considerando que cada par produz exatamente um par de filhotes cada mês, e cada par de filhotes torna - se fértil depois de exatamente um mês.
            //Solicite ao usuário quantos pares existem inicialmente e quantos pares ele deseja ter.
            //Calcule para ele quantos meses são necessários para chegar na quantidade de par de coelho desejado.
            //OBS: Considere que todos os coelhos iniciais já estão fertil.

            int inicial = 20, mesAnterior =0, mesCria = 0, qtdedecoelhos = 0, desejo = 200, meses = 0;

            mesAnterior = inicial;
            qtdedecoelhos = inicial;
            mesCria = qtdedecoelhos;

            while (desejo> qtdedecoelhos)
            {
                qtdedecoelhos = mesAnterior + mesCria;
                mesAnterior = mesCria;
                mesCria = qtdedecoelhos;
                meses++;
            }
            
            Console.WriteLine($"qtde de coelhos{qtdedecoelhos}\n qtde de meses{meses}");
            Console.ReadKey();
        }
    }
}
