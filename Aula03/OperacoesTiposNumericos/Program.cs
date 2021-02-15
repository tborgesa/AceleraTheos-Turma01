using System;

namespace OperacoesTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operações");

            int soma = 10 + 4;
            int subtracao = 10 - 4;
            int multiplicadao = 10 * 4;
            int divisao = 10 / 5;

            int incrementaAntes = 1;
            int incrementaDepois = 1;

            Console.WriteLine($"Antes: {++incrementaAntes}");
            Console.WriteLine($"Depois: {incrementaDepois++}");

            Console.WriteLine($"Final Antes: {incrementaAntes}");
            Console.WriteLine($"Final Depois: {incrementaDepois}");
            Console.WriteLine();

            /*-----------------
             Biblioteca Math */
            double bibliotecaMath = Math.Round(56.87,1);
            Console.WriteLine($"Arredondamento com Round (56,87): {bibliotecaMath}");


            Console.ReadKey();
        }
    }
}
