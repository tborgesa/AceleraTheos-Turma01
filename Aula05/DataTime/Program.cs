using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATA TIME - CONSTRUTOR");

            DateTime dataNew = new DateTime();
            DateTime menorData = DateTime.MinValue;
            DateTime maiorData = DateTime.MaxValue;

            Console.WriteLine($"DataNew: {dataNew}");
            Console.WriteLine($"MenorData: {menorData}");
            Console.WriteLine($"MaiorData: {maiorData}");

            DateTime dataNatal = new DateTime(2018, 12, 25);
            DateTime dataNatalComHora = new DateTime(2018, 12, 25, 22, 00, 00);


//            int diaNatalhojes = dataNatal.Date.Day;
//            DayOfWeek diaSemana = dataNatal.DayOfWeek;
            int diaAno = dataNatal.DayOfYear;

            DateTime hoje = DateTime.Today;
            DateTime hojeComHora = DateTime.Now;

            Console.WriteLine($"Data Atual: {hoje}");
            Console.WriteLine($"Agora: {hojeComHora}");

            DateTime amanha = hoje.AddDays(1);
            DateTime ontem = hoje.AddDays(-1);

            Console.WriteLine($"Data Atual: {amanha}");
            Console.WriteLine($"Agora: {ontem}");

            System.DateTime dataNovo = new System.DateTime();
            Console.WriteLine(dataNew.Day);

            DateTime primeiroDiaMesAtual = new DateTime(hoje.Date.Year, hoje.Date.Month, 1);
            DateTime ultimoDiaMesAtual = new DateTime(hoje.Date.Year,hoje.Date.Month,DateTime.DaysInMonth(hoje.Date.Year, hoje.Date.Month));

            Console.WriteLine($"PrimeiroDia: {primeiroDiaMesAtual}");
            Console.WriteLine($"UltimoDia: {ultimoDiaMesAtual}");

            Console.WriteLine($"Dia Atual {hoje.ToString("ddd",new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Dia Atual {hoje:ddd}");

            Console.ReadKey();
        }

    }
}

