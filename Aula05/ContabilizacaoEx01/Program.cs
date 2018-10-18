using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContabilizacaoEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data emissão da conta a pagar");
            DateTime dataEmissao = DateTime.Parse(Console.ReadLine());

            DateTime primeiroDia = new DateTime(dataEmissao.Date.Year, dataEmissao.Date.Month, 1);

            Console.WriteLine($@"Data de emissão: {dataEmissao:dd/MM/yyyy}
Primeiro dia do mês: {primeiroDia:dd/MM/yyyy}");
            Console.ReadKey();
        }
    }
}
