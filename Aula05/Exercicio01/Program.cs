using System;
/*
 1. A contabilização de uma determinada "Conta a Pagar" é feita sempre no primeiro dia do mês da data de emissão.
	Solicite a data de emissão da conta a Pagar e retorne o primeiro dia do mês da emissão.
     */

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = "16/10/2018";
            var data = DateTime.Parse(user);

            DateTime primeiroDiaMesAtual = new DateTime(data.Date.Year, data.Date.Month, 1);

            Console.WriteLine($"Corrido {primeiroDiaMesAtual.ToString("MMMM dd, yyyy")}");
            Console.WriteLine($"Data {primeiroDiaMesAtual:dd/MM/yyyy}");

            //Retono do formato é livre

            Console.ReadKey();
        }
    }
}
