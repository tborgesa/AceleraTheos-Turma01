using System;

namespace ProvaInicial.AlteracaoSenhaDia
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             Questão 1 (2 pontos)
                
                A equipe de Negócio da Theos solicitou a equipe de Desenvolvimento que alterasse a forma
                com que a senha do dia estava sendo calculada. O desenvolvedor responsável criou um novo
                algoritmo para calcular a senha, descrito abaixo:

                public int CalcularSenhaDia(DateTime data)
                {
                    int valorBase = data.Year + data.Month * data.Day;
                    return valorBase / ((data.Day % 5) + 1);
                }

                Calcule a senha dos seguintes dias:

                25/09/2018 (1 ponto)
                02/10/2018 (1 ponto)
             */
            var data = new DateTime(2018, 09, 25);
            var data1 = new DateTime(2018, 10, 02);
            Console.WriteLine(new SenhaDia().CalcularSenhaDia(data)); //2243
            Console.WriteLine(new SenhaDia().CalcularSenhaDia(data1)); //679
            Console.ReadKey();
        } 
    }
}