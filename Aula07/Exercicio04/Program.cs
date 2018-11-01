using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio04.Helpers;

namespace Exercicio04
{
    public class Program
    {
        static int qtdeInicialCoelhos = 0, qtdeCoelhoFertil = 0, qtdeCoelhoInfertil = 0, qtdeCoelhosTotais = 0, desejo = 0, mesesNecessarios = 0;
      

        static void Main(string[] args)
        {
            //4) Os coelhos se reproduzem todo mês.
            //Considerando que cada par produz exatamente um par de filhotes cada mês, e cada par de filhotes torna - se fértil depois de exatamente um mês.
            //Solicite ao usuário quantos pares existem inicialmente e quantos pares ele deseja ter.
            //Calcule para ele quantos meses são necessários para chegar na quantidade de par de coelho desejado.
            //OBS: Considere que todos os coelhos iniciais já estão fertil.          
            
            //Console.Write("Digite a quantidade inicial de coelhos: ");
            qtdeInicialCoelhos = Input.GetInputInt("Digite a quantidade inicial de coelhos: ", "Caractere invalido, digite um numero real de pares");
            //qtdeInicialCoelhos = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Digite a quantidade desejada de coelhos: ");
            desejo = Input.GetInputInt("Digite a quantidade desejada de coelhos: ", "Caractere invalido, digite um numero real de pares");
            if (qtdeInicialCoelhos == 1)
                mesesNecessarios = 1;

           
            Reproduzir();
                        
            Console.WriteLine($"No final foi preciso {mesesNecessarios} mes(es) para ter no minimo quantidade a desejada de {desejo} coelhos \ne quantidade que resultou foi {qtdeCoelhosTotais} coelhos.");
            Console.ReadKey();
        }



        static void Reproduzir()
        {
            qtdeCoelhoFertil = qtdeInicialCoelhos;
            qtdeCoelhosTotais = qtdeInicialCoelhos;
            qtdeCoelhoInfertil = qtdeCoelhosTotais;

            while (desejo > qtdeCoelhosTotais)
            {
                qtdeCoelhosTotais = qtdeCoelhoFertil + qtdeCoelhoInfertil;
                qtdeCoelhoFertil = qtdeCoelhoInfertil;
                qtdeCoelhoInfertil = qtdeCoelhosTotais;
                mesesNecessarios++;
                Console.WriteLine($"Em {mesesNecessarios} mes(es) temos {qtdeCoelhosTotais} coelhos.");
            }
        }

    }
}
