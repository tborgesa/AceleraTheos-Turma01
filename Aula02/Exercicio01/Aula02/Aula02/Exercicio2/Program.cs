using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor x Referencia");
            int valor = 54;
            int valor2 = Alterar(ref valor);
            valor2 = 4;

            Console.WriteLine($"Valor: {valor}.");
            Console.WriteLine($"Valor: {valor2}.");
            Console.ReadKey();
            
        }

        static int Alterar(ref int valor)
        {
            return valor = 2; 
        }
    }
}
