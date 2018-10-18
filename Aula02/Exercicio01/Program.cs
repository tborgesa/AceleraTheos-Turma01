using System;


namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string sNome = Console.ReadLine();

            Console.WriteLine($"Bem Vindo {sNome} e meus parabéns {sNome} !!! e isso aqui é {GetMensagem()}");
            Console.ReadKey();
        }

        static string GetMensagem()
        {
            return "Retorno de String";
        }
    }
}
