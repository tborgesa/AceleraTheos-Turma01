using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostosEx03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data de emissão da Nota Fiscal");
            DateTime dataEmissao = DateTime.Parse(Console.ReadLine());

            DateTime dataMesFuturo = dataEmissao.AddMonths(1);

            dataMesFuturo = new DateTime(dataMesFuturo.Year, dataMesFuturo.Month, 15);
            Console.WriteLine($"Data do pagamento do imposto: {dataMesFuturo:dd/MM/yyyy}");

            Console.ReadKey();

        }
    }
}
