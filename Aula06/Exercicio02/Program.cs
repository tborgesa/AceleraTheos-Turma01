using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite um numero de 1 a 10 ao usuário e calcule a tabuada desse número.

            int numero;
            var _mensagemErrado = "Numero errado";
            Console.WriteLine("Digite um numero de 1 a 10");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0 && numero > 10)
            {

                Console.WriteLine(_mensagemErrado);

            }

            else
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }
            }

            //Tabuada();

            Console.ReadKey();
        }

        
}

        /*private static void Tabuada()
        {
            int numero;
            var _mensagemErrado = "Numero errado";
            Console.WriteLine("Digite um numero de 1 a 10");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0 && numero > 10)
            {
                Console.WriteLine(_mensagemErrado);

            }
            else
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }
            }


        }*/

    }
}
