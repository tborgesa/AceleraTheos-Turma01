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
            //3) Peça um numero para o usuario e calcule o fatorial desse numero.
            int resultado;

            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            resultado = numero;

            while (numero>1)
            {
                numero--;
                resultado = resultado * numero;
                
            }
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
