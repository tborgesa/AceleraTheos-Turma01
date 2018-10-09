using System;

namespace Exercicio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("por favor, informe um número: ");

            int numero = Convert.ToInt32(Console.ReadLine());
            ref int numeroCopiado = ref numero;
            numeroCopiado = numeroCopiado * 2;

            Console.WriteLine($"O numero é: {numero}, e o dobro do numero é:  {numeroCopiado} ");
            Console.ReadKey();
        }
    }
}
