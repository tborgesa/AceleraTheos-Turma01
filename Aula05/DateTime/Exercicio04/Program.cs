using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 4. Novamente a Senha do dia foi alterada.
	A nova regra diz que deverá somar o dia ao ano e do resultado multiplicar no mês. 
    Do resultado ainda deverá ser dividido pelo dia semana acrescido de 1 (para evitar divisão por zero)
*/
namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Parse("21/10/2018");

            var resultado = ((data.Day + data.Year) * data.Month) /  (int)(data.DayOfWeek+1);

            DayOfWeek diaSemana = data.DayOfWeek;
            DayOfWeek diaSemana1 = data.DayOfWeek + 10;

            Console.WriteLine($"{resultado}");

            Console.ReadKey();


        }
    }
}
