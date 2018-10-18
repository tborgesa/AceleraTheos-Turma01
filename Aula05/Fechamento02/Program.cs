using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechamento02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFechamento = new DateTime();
            Console.WriteLine("Informe o ano de fechamento contábil");
            int ano = int.Parse(Console.ReadLine());
             
            dataFechamento = new DateTime(ano, 12, DateTime.DaysInMonth(ano, 12));

            Console.WriteLine($"Último dia do ano: {dataFechamento:dd/MM/yyyy}");
            Console.ReadKey();
        }
    }
}
