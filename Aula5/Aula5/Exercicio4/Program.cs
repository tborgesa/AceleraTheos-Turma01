using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Novamente a Senha do dia foi alterada.
            //A nova regra diz que deverá somar o dia ao ano e do resultado multiplicar no mês.Do resultado 
            //ainda deverá ser dividido pelo dia semana acrescido de 1(para evitar divisão por zero)

            DateTime hoje = DateTime.Now;
            var dia = hoje.Date.Day;
            var ano = hoje.Date.Year;
            var mes = hoje.Date.Month;
            DayOfWeek diaSemana = (hoje.DayOfWeek)+1;


            int senha = ((dia + ano) * mes) ;
            senha = senha / (int)diaSemana;
            Console.WriteLine($"A senha do dia é: {senha}");

            Console.ReadKey();

        }
    }
}
