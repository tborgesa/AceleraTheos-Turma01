using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. A contabilização de uma determinada "Conta a Pagar" é feita sempre no primeiro dia do mês da data de emissão.
            //Solicite a data de emissão da conta a Pagar e retorne o primeiro dia do mês da emissão.

            Console.WriteLine("Digite a data de emissão do Conta a Pagar");
            DateTime dataEmissao = DateTime.Parse(Console.ReadLine());

            DateTime dataContabilizacao = new DateTime(dataEmissao.Year, dataEmissao.Month, 1);

            Console.WriteLine($"A data da contabilização da conta a pagar é {dataContabilizacao:dd/MM/yyyy}");

            Console.ReadKey();
        }
    }
}
