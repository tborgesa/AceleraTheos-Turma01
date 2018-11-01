using System;

namespace Exercicio3.Consumo
{
    class Program
    {
        //3. Calcular o consumo de combustivel numa determinada distancia. (Km/l)
        //1.Solicitar Kilometragem inicial.
        //2.Solicitar Kilometragem final.
        //3.Solicitar quantidade de litros gasto.

        //OBS: Deve ser considerado apenas a parte inteira do valor.  

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Kilometragem inicial:");
            double kilometragemInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a kilometragem final:");
            double kilometragemFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de litros gastos:");
            double quantidadeLitros = Convert.ToDouble(Console.ReadLine());

            double kilometragemTotal = kilometragemFinal - kilometragemInicial;

            double consumoCombustivel = kilometragemTotal / quantidadeLitros;
            Console.WriteLine($"O consumo médio é de {(int)consumoCombustivel} Km/l.");
            
            Console.ReadKey();
        }
    }
}
