using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. O sistema de passorte sempre obriga que o ultimo nome sempre venha primeiro nos documentos.
            //Solicite o nome completo do usuario e apresente para ele "UltimoNome, PrimeiroNome" como é apresentado no passaporte.


            Console.WriteLine("Por favor, informe seu nome completo.");
            string nomeCompleto = Console.ReadLine();


            var nome = nomeCompleto.Substring(0, nomeCompleto.IndexOf(" "));
            var Sobrenome = nomeCompleto.Substring(nomeCompleto.LastIndexOf(" "));
            Console.WriteLine($"Primeiro Nome: {nome}");
            Console.WriteLine($"Último Nome: {Sobrenome}");


            Console.ReadKey();

        }
    }
}
