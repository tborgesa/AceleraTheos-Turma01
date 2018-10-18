using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. A contabilização de uma determinada "Conta a Pagar" é feita sempre no primeiro dia do mês da data de emissão.
            //Solicite a data de emissão da conta a Pagar e retorne o primeiro dia do mês da emissão.


            Console.WriteLine("Por favor, informe a data de emissão da conta a pagar.");
            DateTime dataEmissao = Convert.ToDateTime(Console.ReadLine());

            DateTime primeiroDiaMes = new DateTime(dataEmissao.Date.Month, dataEmissao.Date.Month,1);
            Console.WriteLine($"primeiro dia do mês da emissão é: {primeiroDiaMes: dd/MM}.");


            Console.ReadKey();
        }
    }
}
