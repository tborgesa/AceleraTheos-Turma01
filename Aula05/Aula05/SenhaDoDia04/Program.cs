using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenhaDoDia04
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataHoje = DateTime.Today;

             int senha = ((dataHoje.Year + dataHoje.Day) * dataHoje.Month) / (int)(dataHoje.DayOfWeek + 1);

             Console.WriteLine($"Senha do dia: {senha}");

             Console.ReadKey();
             
        }
    }
}
