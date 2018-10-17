using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Novamente a Senha do dia foi alterada.
            //A nova regra diz que deverá somar o dia ao ano e do resultado multiplicar no mês.Do resultado 
            //ainda deverá ser dividido pelo dia semana acrescido de 1(para evitar divisão por zero)

            DateTime hojeSenha = DateTime.Today;

            int senhaDia;
            senhaDia = ((hojeSenha.Year + hojeSenha.Day) * hojeSenha.Month)/Convert.ToInt32(hojeSenha.DayOfWeek+1);

            Console.WriteLine($"{senhaDia}");

            Console.ReadKey();

        }
    }
}
