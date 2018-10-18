using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Os impostos federais sempre são pagos no dia 15 no mês seguinte ao pagamento da Nota Fiscal.
            //Solicite ao usuário a data de emissão da Nota Fiscal e retorne a data que será paga o imposto


            Console.WriteLine("Por favor, informe a data de emissão da nota fiscal.");
            DateTime dataEmissao = Convert.ToDateTime(Console.ReadLine());

            DateTime MesSeguinte = dataEmissao.AddMonths(1);
            DateTime quintoDiaMesSeguinte = new DateTime (MesSeguinte.Date.Year, MesSeguinte.Date.Month, 15);
            Console.WriteLine($"a data de pagamento do imposto é: {quintoDiaMesSeguinte: dd/MM/yyyy}.");

            Console.ReadKey();
        }
    }
}
