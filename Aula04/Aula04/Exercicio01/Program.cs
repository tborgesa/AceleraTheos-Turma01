using System;


/*
 1. O sistema de passorte sempre obriga que o ultimo nome sempre venha primeiro nos documentos.
Solicite o nome completo do usuario e apresente para ele "UltimoNome, PrimeiroNome" como é apresentado no passaporte.     
     */

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome completo:");
            string nomeCompleto = Console.ReadLine();

            var aux = nomeCompleto.IndexOf(" ");
            var auxfim = nomeCompleto.LastIndexOf(" ");

            Console.WriteLine("Tamanho"+ nomeCompleto.Length);

            Console.WriteLine($"IndexOf{aux} e LastIndexOf{auxfim}");

            var cont = nomeCompleto.Length;

            Console.WriteLine($"Seu Primeiro nome é {nomeCompleto.Substring(0, aux)}");
            Console.WriteLine($"Seu Ultimo nome é {nomeCompleto.Substring(auxfim)}");


            Console.ReadKey();
        }
    }
}
