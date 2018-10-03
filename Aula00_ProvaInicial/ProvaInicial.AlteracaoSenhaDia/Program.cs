using System;

namespace ProvaInicial.AlteracaoSenhaDia
{
    public class Program
    {
        static void Main(string[] args)
        {
            var data = new DateTime(2018, 09, 25);
            var data1 = new DateTime(2018, 10, 02);
            Console.WriteLine(new SenhaDia().CalcularSenhaDia(data)); //2243
            Console.WriteLine(new SenhaDia().CalcularSenhaDia(data1)); //679
            Console.ReadKey();
        }
    }
}