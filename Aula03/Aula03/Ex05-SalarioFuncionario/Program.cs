using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0.0;

            Console.WriteLine("Digite o salário do funcionário");
            salario = double.Parse(Console.ReadLine());

            salario += salario * 0.05;

            Console.WriteLine($"O reajuste do salário foi de 5%, salário atual: {salario:n2}");

            Console.ReadKey();

        }
    }
}
