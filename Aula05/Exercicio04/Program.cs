using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Novamente a Senha do dia foi alterada.
            //A nova regra diz que deverá somar o dia ao ano e do resultado multiplicar no mês.
            //Do resultado ainda deverá ser dividido pelo dia semana acrescido de 1(para evitar divisão por zero)

            DateTime dataSenha = DateTime.Today;

            var soma = dataSenha.Day + dataSenha.Year;
            var multiplicacao = soma * dataSenha.Month;
            var senha = multiplicacao / ((int)dataSenha.DayOfWeek + 1);

            Console.WriteLine($"A senha do dia {dataSenha:dd/MM/yyyy} é {senha}");

            Console.ReadLine();
        }
    }
}
