using System;
/*
 * 
3. Calcular o consumo de combustivel numa determinada distancia. (Km/l)
 1. Solicitar Kilometragem inicial.
 2. Solicitar Kilometragem final.
 3. Solicitar quantidade de litros gasto.
 */

namespace Exercicio03
{
    class Program
    {

        static void Main(string[] args)
        {
            double  start, 
                    end, 
                    gas;

            int consumo_medio;

            Console.WriteLine("Digite o valor do Kilometro Inicial");
            start = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valro do Kilometro Final");
            end = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de gasto litros combustivel");
            gas = Double.Parse(Console.ReadLine());

            consumo_medio = (int)(( end - start ) / gas);

            Console.WriteLine($"O consumo medio é : {consumo_medio} Km/L");
            Console.ReadKey();
        }
    }
}
