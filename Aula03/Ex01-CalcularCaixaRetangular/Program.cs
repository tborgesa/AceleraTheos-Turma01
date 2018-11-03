using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_CalcularCaixaRetangular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular volume de uma caixa retangular");

            double volume;
            double altura;
            double comprimento;
            double largura;

            Console.WriteLine("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento: ");
            comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura: ");
            largura = double.Parse(Console.ReadLine());

            volume = altura * comprimento * largura;

            Console.WriteLine($"Volume: {volume}");

            Console.ReadKey();

        }
    }
}
