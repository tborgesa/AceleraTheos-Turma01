using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3. Os impostos federais sempre são pagos no dia 15 no mês seguinte ao pagamento da Nota Fiscal.
	Solicite ao usuário a data de emissão da Nota Fiscal e retorne a data que será paga o imposto.
*/

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = DateTime.Parse("31/12/2018");
            data = data.AddMonths(1);

            DateTime aux = new DateTime(data.Year,data.Month,15);

            Console.WriteLine($"Data de pagamento será {aux:dd/MM/yyyy}");
            Console.ReadKey();
        }
    }
}
