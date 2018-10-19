using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             2. O fechamento contábil anual sempre acontece no ultimo dia do ano.
	        Solicite ao usuário o ano de fechamento e retorne a data que será feito o fechamento Contábil.
             */

            Console.WriteLine($"Digite o ano do fechamento contábil:");

            int ano = int.Parse(Console.ReadLine());

            DateTime dataFechamentoContabil = new DateTime(ano, 12, DateTime.DaysInMonth(ano,12));

            Console.WriteLine($"A data do fechamento contábil desse ano é: {dataFechamentoContabil:dd/MM/yyyy}");

            Console.ReadLine();

        }
    }
}
