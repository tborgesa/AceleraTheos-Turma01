using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransacaoCartaoEx05
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataTransacao = new DateTime();
            Console.WriteLine("Informe a data da transação");
            dataTransacao = DateTime.Parse(Console.ReadLine());

            DateTime dataInicialFiltro = new DateTime(dataTransacao.Date.Year, dataTransacao.Date.Month, 1);
            DateTime dataFimFiltro = new DateTime(dataTransacao.Date.Year, dataTransacao.Date.Month, DateTime.DaysInMonth(dataTransacao.Date.Year, dataTransacao.Date.Month));

            Console.WriteLine($"Data inicial do filtro: {dataInicialFiltro}\n" +
                              $"Data final do filtro: {dataFimFiltro}");

            Console.ReadKey();

        }
    }
}
