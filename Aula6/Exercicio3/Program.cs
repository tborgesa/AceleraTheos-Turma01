using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Solicite ao usuário 10 números e no final diga quantos números são menores que 100, quantos estão entre 100 e 200 e quantos são maiores que 200.


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Informe um número.");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 100)
                {
                    int menor100 = numero;
                    Console.WriteLine($"Numeros menores que 100: {menor100}");
                }
                else if (numero >= 100 || numero <= 200)
                {
                    int entre100200 = numero;
                    Console.WriteLine($"Numeros entre  100 e 200: {entre100200}");
                }
                else if (numero > 200)
                {
                    int maior200 = numero;
                    Console.WriteLine($"Numeros maiores que 200: {maior200}");
                }

            }




        }
    }
}
