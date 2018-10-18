using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. A contabilização de uma determinada "Conta a Pagar" é feita sempre no primeiro dia do mês da data de emissão. 
                  Solicite a data de emissão da conta a Pagar e retorne o primeiro dia do mês da emissão.*/

            Console.WriteLine("Digite a data de emissão da Conta a Pagar:");
            DateTime dataEmissaCP = DateTime.Parse(Console.ReadLine());

            DateTime primeiroDiaMes = new DateTime(dataEmissaCP.Date.Year, dataEmissaCP.Date.Month, 1);

            Console.WriteLine($"O primeiro dia do mês da emissão é: {primeiroDiaMes:dd}");

            Console.ReadKey();
        }
    }
}
