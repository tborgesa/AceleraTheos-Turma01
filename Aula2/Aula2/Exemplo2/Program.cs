using System;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor x Referencia");

            int valor = 5;
            int valor2 = Alterar(ref valor);//(valor)

            Console.WriteLine($"Valor: {valor}.");
            Console.WriteLine($"Valor2: {valor2}.");
            Console.ReadKey();
        }

        static int Alterar( ref int valor)//(int valor)
        {
            return valor = 2;
        }
    }

    
}
