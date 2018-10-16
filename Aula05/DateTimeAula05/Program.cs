using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAula05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATE TIME - CONSTRUTOR");

            DateTime dataNew = new DateTime();
            DateTime menorData = DateTime.MinValue;
            DateTime maiorData = DateTime.MaxValue;



            Console.WriteLine($"datanew :{dataNew}");
            Console.WriteLine($"menordata {menorData}");
            Console.WriteLine($"maiordata {maiorData}");

            DateTime dataNatal = new DateTime(2018, 12, 25);
            DateTime dataNatalComHora = new DateTime(2018, 12, 25, 22, 00, 00);


            int diaNatal = dataNatal.Date.Day;
            DayOfWeek diaSemana = dataNatal.DayOfWeek;
            int diaAno = dataNatal.DayOfYear;


            Console.WriteLine($"DataNatal: {dataNatal}");
            Console.WriteLine($"DataNatal: {dataNatalComHora}");
            Console.WriteLine($"DiaNatal: {diaNatal}");

            DateTime hoje = DateTime.Today;
            DateTime hojeComHora = DateTime.Now;

            Console.WriteLine($"Data Atual {hoje}");
            Console.WriteLine($"Agora {hojeComHora}");

            DateTime amanha = hoje.AddDays(1);
            DateTime ontem = hoje.AddDays(-1);

            Console.WriteLine($"Amanha {amanha}");
            Console.WriteLine($"ontem {ontem}");

            DateTime primeiroDiaMesAtual = new DateTime(hoje.Date.Year, hoje.Date.Month, 1);
            DateTime ultimoDiaMesAtual = new DateTime(hoje.Date.Year, hoje.Date.Month, DateTime.DaysInMonth(hoje.Date.Year, hoje.Date.Month));

            Console.WriteLine($"primeiro dia{primeiroDiaMesAtual}");
            Console.WriteLine($"ultimo dia{ultimoDiaMesAtual}");

            Console.WriteLine($"dia atual {hoje.ToString("%d")}");
            Console.WriteLine($"dia atual {hoje:%d}");
            Console.WriteLine($"dia atual {hoje:dd/MM/yyyy HH:mm:ss}");
            Console.WriteLine($"TimeZone {hojeComHora:u}");



            Console.ReadKey();
        }
    }
}
