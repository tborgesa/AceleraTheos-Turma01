using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Os impostos federais sempre são pagos no dia 15 no mês seguinte ao pagamento da Nota Fiscal.
            //Solicite ao usuário a data de emissão da Nota Fiscal e retorne a data que será paga o imposto.

            Console.WriteLine("Digite a data de emissão na Nota Fiscal:");

            DateTime dataEmissao = DateTime.Parse(Console.ReadLine());

            int anoImposto = dataEmissao.AddMonths(1).Year;
            int mesImposto = dataEmissao.AddMonths(1).Month;

            DateTime dataImposto = new DateTime(anoImposto, mesImposto, 15);

            Console.WriteLine($"A data da imposto da conta a pagar é {dataImposto:dd/MM/yyyy}");
            Console.ReadKey();

        }
    }
}
