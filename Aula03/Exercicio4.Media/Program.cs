using System;

namespace Exercicio4.Media
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Calcular a media final de um aluno, sabendo que ele realizou quatro provas no ano.
            // 1. Solicitar a nota de cada prova.
            //2. Solicitar o nome do aluno para apresentar na mensagem final.
            //OBS: Deve ser arredondado (Math.Round) e apresentar apenas a parte inteira da nota.


            Console.WriteLine("Digite o nome do aluno:");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota:");
            double primeiraNota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double segundaNota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            double terceiraNota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota:");
            double quartaNota = Convert.ToDouble(Console.ReadLine());
            
            double mediaFinal = (primeiraNota + segundaNota + terceiraNota + quartaNota) / 4;
            mediaFinal = Math.Round(mediaFinal);
            
            Console.WriteLine($"A nota Final do aluno {nomeAluno} é {mediaFinal}.");

            Console.ReadKey();
        }
    }
}
