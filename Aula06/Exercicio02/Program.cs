using System;

/*2. Solicite um numero de 1 a 10 ao usuário e calcule a tabuada desse número.*/
namespace Exercicio02
{
    class Program
    {
        static string _mensagemInvalido = "Entrada inválida, execute o sistema e tente novamente!";
        static int entrada;

        static void Main(string[] args)
        {
            bool check = true;

            while (check)
            {
                Console.Clear();

                Console.WriteLine("Insira um valor de 1 a 10");
                var put = Console.ReadLine();

                if (!int.TryParse(put, out entrada))
                {
                    Console.WriteLine(_mensagemInvalido);
                    Console.ReadKey();
                }

                else if (entrada < 0 || entrada > 10)
                {
                    Console.WriteLine("Valor incorreto");
                    Console.ReadKey();
                }

                else
                {
                    check = false;
                }

            }

            Console.Clear();

            Console.WriteLine("\t Tabuada :");

            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {entrada} = {i * entrada}");
            }

            Console.ReadKey();

        }
    }
}