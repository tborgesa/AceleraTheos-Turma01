using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Os impostos federais sempre são pagos no dia 15 no mês seguinte ao pagamento da Nota Fiscal.
            //Solicite ao usuário a data de emissão da Nota Fiscal e retorne a data que será paga o imposto.

            Console.WriteLine("Digite a data da emissão da nota fiscal");

            DateTime dataEmissao = new DateTime();
            dataEmissao = DateTime.Parse(Console.ReadLine());
            Console.Clear();

            DateTime trabComData = dataEmissao.AddMonths(1);

            /*DateTime dataPagamento = new DateTime();
            if (dataEmissao.Month == 12)
            {
                dataPagamento = new DateTime(dataEmissao.Year+1, 1, 15);
            }
            else
            {
                dataPagamento = new DateTime(dataEmissao.Year, dataEmissao.Month + 1, 15);
            }*/

            DateTime dataPagamento = new DateTime(trabComData.Year, trabComData.Month, 15);



            Console.WriteLine($"A data do pagamento é : {dataPagamento:dd/MM/yyyy}");

            Console.ReadKey();

        }
    }
}
