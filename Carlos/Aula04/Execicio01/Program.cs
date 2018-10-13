using System;

namespace Execicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. O sistema de passorte sempre obriga que o ultimo nome sempre venha primeiro nos documentos.
            Solicite o nome completo do usuario e apresente para ele "UltimoNome, PrimeiroNome" como é apresentado no passaporte.*/

            string nomeCompleto;

            Console.WriteLine("Digite o nome completo:");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine($"\n{nomeCompleto.Substring(nomeCompleto.IndexOf(" "))},{nomeCompleto.Substring(0, nomeCompleto.IndexOf(" "))}");

            Console.ReadKey();
        }
    }
}
