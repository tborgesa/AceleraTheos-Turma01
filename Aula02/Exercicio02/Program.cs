using System;

namespace ValorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://www.macoratti.net/17/01/cshp_primit1.htm
            Console.WriteLine("VALOR X REFERENCIA");

            int numeroPorValor = 5;
            int numero2PorValor = numeroPorValor;
            numeroPorValor = 2;

            Console.WriteLine($"Número por Valor: {numeroPorValor}.");
            Console.WriteLine($"Número por Valor 2: {numero2PorValor}.");
            Console.WriteLine("***************************");

            int valorPorReferencia = 5;
            ref int valor2PorReferencia = ref valorPorReferencia;
            valor2PorReferencia = 2;

            Console.WriteLine($"Número por Referência: {valorPorReferencia}.");
            Console.WriteLine($"Número por Referência 2: {valor2PorReferencia}.");
            Console.WriteLine("***************************");

            Thiago thiago = new Thiago();
            thiago.Nome = "Thiago";

            Thiago thiago2 = thiago;
            thiago2.Nome = "Mudou!";

            Console.WriteLine($"Classe Thiago: {thiago.Nome}.");
            Console.WriteLine($"Classe Thiago2: {thiago2.Nome}.");
            Console.ReadKey();
        }
    }

    public class Thiago
    {
        public string Nome;
    }
}
