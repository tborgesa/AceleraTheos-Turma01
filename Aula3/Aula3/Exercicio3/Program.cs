﻿using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Calcular o consumo de combustivel numa determinada distancia. (Km/l)
            //1.Solicitar Kilometragem inicial.
            //2.Solicitar Kilometragem final.
            //3.Solicitar quantidade de litros gasto.
            //OBS: Deve ser considerado apenas a parte inteira do valor.


            Console.WriteLine("por favor, Informe a Kilometragem inicial");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("por favor, Informe a Kilometragem final");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("por favor, Informe a quantidade de litros gastos");
            double litrosGastos = Convert.ToDouble(Console.ReadLine());

            double kmTotal = kmFinal - kmInicial;

            double consumoCombustivel = kmTotal / litrosGastos;
            consumoCombustivel = Math.Round(consumoCombustivel);
            Console.WriteLine($"O consumo médio é de {consumoCombustivel} Km/l.");


            Console.ReadKey();
        }
    }
}