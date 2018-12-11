using System;

namespace ProvaInicial.Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var operacao1 = new Operacao(4, 2);
            Console.WriteLine($"Soma: {operacao1.Soma()}");
            Console.ReadKey();
        }
    }
}
