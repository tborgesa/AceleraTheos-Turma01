using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. O fechamento contábil anual sempre acontece no ultimo dia do ano.
                  Solicite ao usuário o ano de fechamento e retorne a data que será feito o fechamento Contábil.*/

            Console.WriteLine("Digite o ano de fechamento:");
            int anoFechamento = int.Parse(Console.ReadLine());

            DateTime dataFechamentoContabil = new DateTime(anoFechamento,12,31);
            

            Console.WriteLine($"A data do fechamento contábil é: {dataFechamentoContabil:dd/MM/yyyy}");


            Console.ReadKey();
        }
    }
}
