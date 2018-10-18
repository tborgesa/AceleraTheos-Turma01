using System;
using System.Globalization;

namespace Aula05DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATE TIME - CONSTRUTOR");

            DateTime dataNew = new DateTime();
            DateTime menorDate = DateTime.MinValue;
            DateTime maiorDate = DateTime.MaxValue;

            Console.WriteLine($"DataNew: {dataNew}");
            Console.WriteLine($"Menordate: {menorDate}");
            Console.WriteLine($"Maiordate: {maiorDate}");

            DateTime dataNatal = new DateTime(2018,12,25);
            Console.WriteLine($"DataNatal: {dataNatal}");

            int diaNatal = dataNatal.Date.Day;
            Console.WriteLine($"DiaNatal: {diaNatal}");

            DayOfWeek diaSemana = dataNatal.DayOfWeek;
            Console.WriteLine($"DiaSemana: {diaSemana}");

            int diaAno = dataNatal.DayOfYear;

            DateTime dataNatalComHora = new DateTime(2018, 12, 25,22,00,00);
            Console.WriteLine($"DataNatal: {dataNatalComHora}");

            DateTime hoje = DateTime.Today;
            Console.WriteLine($"DataAtual: {hoje}");

            DateTime hojeComHora = DateTime.Now;
            Console.WriteLine($"Agora: {hojeComHora}");

            DateTime amanha = hoje.AddDays(1);
            Console.WriteLine($"Amanha: {amanha}");

            DateTime ontem = hoje.AddDays(-1);
            Console.WriteLine($"Ontem: {ontem}");

            DateTime primeiroDiaMesAtual = new DateTime(hoje.Date.Year, hoje.Date.Month, 1);
            DateTime ultimoDiaMesAtual = new DateTime(hoje.Date.Year,hoje.Date.Month,DateTime.DaysInMonth(hoje.Date.Year, hoje.Date.Month));
            Console.WriteLine($"PrimeiroDiaMes: {primeiroDiaMesAtual}");
            Console.WriteLine($"UltimoDiaMes: {ultimoDiaMesAtual}");

            Console.WriteLine($"Dia Atual: {hoje:dd}");
            //Ou...
            Console.WriteLine($"Dia Atual: {hoje.ToString("dd")}");
            //OU...
            Console.WriteLine($"Dia Atual: {hoje.ToString("ddd",new CultureInfo("pt-BR"))}");
            //Ou..
            Console.WriteLine($"Dia Atual: {hoje:dd/MM/yyyy HH:mm:ss}");
            //Ou...
            Console.WriteLine($"Time Zone: {hojeComHora:%z}"); 


            Console.ReadKey();
        }
    }
}
