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
            //1. O sistema de passorte sempre obriga que o ultimo nome sempre venha primeiro nos documentos.
            //Solicite o nome completo do usuario e apresente para ele "UltimoNome, PrimeiroNome" como é apresentado no passaporte.

            //if e for ou lastindexof

            string nomeCompleto;
            string primeiroNome;
            string ultimoNome;

            Console.WriteLine("digite seu nome completo");
            nomeCompleto = Console.ReadLine();

            
            ultimoNome = nomeCompleto.Substring(nomeCompleto.LastIndexOf(" "));
            primeiroNome = nomeCompleto.Remove(nomeCompleto.LastIndexOf(" "));


            Console.WriteLine($"{ultimoNome.Trim()}, {primeiroNome}");
        

            Console.ReadKey();

        }
    }
}
