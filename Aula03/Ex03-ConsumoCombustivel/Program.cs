using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_ConsumoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular consumo de combustível");

            double kilometragemInicial;
            double kilometragemFinal;
            double quantidadeLitrosGastos;
            double consumo;

            Console.WriteLine("Digite a kilometragem inicial");
            kilometragemInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a kilometragem final");
            kilometragemFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos litros gastou");
            quantidadeLitrosGastos = double.Parse(Console.ReadLine());

            consumo = (kilometragemFinal - kilometragemInicial) / quantidadeLitrosGastos;

            Console.WriteLine($"Consumo: {(int)consumo}");

            Console.ReadKey();
        }
    }
}
