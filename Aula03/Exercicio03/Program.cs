using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Calcular o consumo de combustivel numa determinada distancia. (Km / l)
            //1.Solicitar Kilometragem inicial.
            //2.Solicitar Kilometragem final.
            //3.Solicitar quantidade de litros gasto.
            //OBS: Deve ser considerado apenas a parte inteira do valor.

            float kmInicial;
            float kmFinal;
            float qtdeKm;
            float qtdeLitros;
            float resultado;

            Console.WriteLine("Calculo de combustível!\n");
            Console.WriteLine("Digite o km inicial");
            kmInicial = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o km final");
            kmFinal = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de litros gastos");
            qtdeLitros = float.Parse(Console.ReadLine());

            qtdeKm = kmFinal - kmInicial;

            resultado = qtdeKm / qtdeLitros;

            Console.WriteLine($"A quantidade de KM(s) por litro é: {Math.Round(resultado,1)}");
            Console.ReadKey();


        }
    }
}
