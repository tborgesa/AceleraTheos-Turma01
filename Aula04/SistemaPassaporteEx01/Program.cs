using System;

namespace SistemaPassaporteEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de passaporte!");

            string nome;
   
            Console.WriteLine("Digite seu nome completo");
            nome = Console.ReadLine();

            var primeiroIndice = nome.IndexOf(" ");
            
            if (primeiroIndice == -1)
            {
                Console.WriteLine("Nome inválido");
                Console.ReadKey();
                return;
            }

            var indice = nome.Substring(nome.LastIndexOf(" "));
             
            Console.WriteLine($"Passaporte: {indice}, {nome.Substring(0, nome.IndexOf(" "))}");


            Console.ReadKey();
        }
    }
}
