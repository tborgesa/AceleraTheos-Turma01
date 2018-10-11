using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("VARLO X REFERENCIA");

            int valor = 5;
            int valor2 = Alterar(ref valor);

            Console.WriteLine($"Valor: {valor}.");
            Console.WriteLine($"Valor2: {valor2}.");
            Console.ReadKey();
        }

        static int Alterar(ref int valor)
        {
            return valor = 2;
        }
    }
}
