using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Calcular o volume de uma caixa retangular.

            float altura;
            float largura;
            float comprimento;
            float volume;

            Console.WriteLine("Calculando volume de uma caixa retangular!\n");
            Console.WriteLine("Digite a altura");
            altura = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite a largura");
            largura = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite a comprimento");
            comprimento = float.Parse(Console.ReadLine());
            Console.Clear();
            volume = altura * largura * comprimento;

            Console.WriteLine($"o volume é : {volume}");

            Console.ReadKey();
        }
    }
}
