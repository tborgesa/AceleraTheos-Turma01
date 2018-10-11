using System;

/*
 * 4. Calcular a media final de um aluno, sabendo que ele realizou quatro provas no ano.
 1. Solicitar a nota de cada prova.
 2. Solicitar o nome do aluno para apresentar na mensagem final.

 OBS: Deve ser arredondado (Math.Round) e apresentar apenas a parte inteira da nota.
 */

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor nota 1");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor nota 2");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor nota 3");
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor nota 4");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4)/(double)4;

            Console.Clear();
            Console.WriteLine($"A medida das quatro provas resulta {(int)(Math.Round(media))}");
            Console.ReadKey();
        }
    }
}
