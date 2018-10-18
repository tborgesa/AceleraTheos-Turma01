using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4. Novamente a Senha do dia foi alterada.
                  A nova regra diz que deverá somar o dia ao ano e do resultado multiplicar no mês. 
                  Do resultado ainda deverá ser dividido pelo dia semana acrescido de 1 (para evitar divisão por zero)*/

            Console.WriteLine("Digite a data atual:");
            DateTime dataAtual = DateTime.Parse(Console.ReadLine());

            var resultado = (dataAtual.Day + dataAtual.Year) * dataAtual.Month;

            DayOfWeek diaSemana = dataAtual.DayOfWeek;

            var senhaDia = resultado / (Convert.ToInt16(diaSemana) + 1);

            Console.WriteLine($"\nA senha do dia é: {senhaDia}");

            Console.ReadKey();

        }
    }
}
