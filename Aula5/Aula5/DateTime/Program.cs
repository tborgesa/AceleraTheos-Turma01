using System;
using System.Globalization;

namespace DateTimeExemplo
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
            Console.WriteLine($"Menor Data: {menorData}");
            Console.WriteLine($"Maior Data: {maiorData}");


            DateTime dataNatal = new DateTime(2018, 12, 25);
            DateTime dataNatalHora = new DateTime(2018, 12, 25,22,00,00);
            Console.WriteLine($"Data do Natal: {dataNatal}");
            Console.WriteLine($"Data do Natal com hora: {dataNatalHora}");

            int diaNatal = dataNatal.Date.Day;
            Console.WriteLine($"Dia do Natal: {diaNatal}");

            DayOfWeek diaSemana = dataNatal.DayOfWeek;
            int diaAno = dataNatal.DayOfYear;

            Console.WriteLine($"Dia da Semana do Natal: {diaSemana.ToString(new CultureInfo("pt-BR"))}");


            DateTime hoje = DateTime.Now;
            Console.WriteLine($"data atual: {hoje}");
            DateTime hojeHora = DateTime.Today;
            Console.WriteLine($"data atual: {hojeHora}");



            DateTime amanha = hoje.AddDays(1);
            DateTime ontem = hoje.AddDays(-1);
            Console.WriteLine($"Amanhã: {amanha}");
            Console.WriteLine($"Ontem: {ontem}");



            DateTime primeiroDiaMesAtual = new DateTime(hoje.Date.Year, hoje.Date.Month, 1);
            DateTime ultimoDiaMesAtual = new DateTime(hoje.Date.Year, hoje.Date.Month, DateTime.DaysInMonth(hoje.Date.Year, hoje.Date.Month));
            Console.WriteLine($"Primeiro Dia do mês atual: {primeiroDiaMesAtual}");
            Console.WriteLine($"Ultimo dia do mês atual: {ultimoDiaMesAtual}");



            Console.WriteLine($"data atual: {hoje:dd}");



            Console.ReadKey();
        }
    }
}
