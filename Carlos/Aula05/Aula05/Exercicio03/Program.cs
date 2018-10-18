using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3. Os impostos federais sempre são pagos no dia 15 no mês seguinte ao pagamento da Nota Fiscal.
               Solicite ao usuário a data de emissão da Nota Fiscal e retorne a data que será paga o imposto.*/

            Console.WriteLine("Digite a data de emissão da Nota Fiscal:");
            DateTime dataEmissaoNF = DateTime.Parse(Console.ReadLine());

            var dataPagamentoNFFuturo = dataEmissaoNF.AddMonths(+1);
            var mesPagamentoNFFuturo = dataPagamentoNFFuturo.Month;
            var anoPagamentoNFFuturo = dataPagamentoNFFuturo.Year;

            var dataPagamentoImposto = new DateTime(anoPagamentoNFFuturo, mesPagamentoNFFuturo, 15);


            Console.WriteLine($"A data de pagamento do imposto é: {dataPagamentoImposto:dd/MM/yyyy}");


            Console.ReadKey();
        }
    }
}
