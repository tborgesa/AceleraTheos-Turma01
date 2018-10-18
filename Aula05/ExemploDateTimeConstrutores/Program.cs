using System;
using System.Globalization;

namespace ExemploDateTimeConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATE TIME - CONSTRUTOR");

            DateTime dataNew = new DateTime();
            DateTime menorData = DateTime.MinValue;
            DateTime maiorData = DateTime.MaxValue;


            Console.WriteLine($"DataNew: {dataNew}");
            Console.WriteLine($"MenorData: {menorData}");
            Console.WriteLine($"MaiorData: {maiorData}");

            DateTime dataNatal = new DateTime(2018, 12, 25);
            DateTime dataNatalComHora = new DateTime(2018, 12, 25, 22, 00, 00);

            int diaNatal = dataNatal.Date.Day;
            DayOfWeek diaSemana = dataNatal.DayOfWeek;
            int diaAno = dataNatal.DayOfYear;

            Console.WriteLine($"DataNatal: {dataNatal}");
            Console.WriteLine($"DataNatalComHora: {dataNatalComHora}");
            Console.WriteLine($"DiaNatal: {diaNatal}");

            DateTime hoje = DateTime.Today;
            DateTime hojeComHora = DateTime.Now;

            Console.WriteLine($"Data Atual: {hoje}");
            Console.WriteLine($"Agora: {hojeComHora}");

            DateTime amanha = hoje.AddDays(1);
            DateTime ontem = hoje.AddDays(-1);
            //DateTime ontem = hoje.Addyear(-1);

            Console.WriteLine($"Amanhã: {amanha}");
            Console.WriteLine($"Ontem: {ontem}");

            DateTime primeiroDiaMesAtual = new DateTime(hoje.Date.Year, hoje.Date.Month, 1);
            DateTime ultimoDiaMesAtual = new DateTime(hoje.Date.Year, hoje.Date.Month, DateTime.DaysInMonth(hoje.Date.Year, hoje.Date.Month));

            Console.WriteLine($"PrimeiroDia: {primeiroDiaMesAtual}");
            Console.WriteLine($"UltimoDia: {ultimoDiaMesAtual}");

            Console.WriteLine($"Dia Atual: {hoje.ToString("dddd", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Dia Atual: {hoje:dd}");
            Console.WriteLine($"Dia Atual: {hoje:dd/MM/yyyy HH:mm:ss}");

            Console.ReadKey();


        }
    }
}
