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
            //4.Calcular a media final de um aluno, sabendo que ele realizou quatro provas no ano.
            //1.Solicitar a nota de cada prova.
            //2.Solicitar o nome do aluno para apresentar na mensagem final.
            //OBS: Deve ser arredondado (Math.Round) e apresentar apenas a parte inteira da nota.

            float prova1;
            float prova2;
            float prova3;
            float prova4;
            float media;

            Console.WriteLine("Calculo de Média de um aluno");

            Console.WriteLine("Digite a nota da prova 1");
            prova1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da prova 2");
            prova2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da prova 3");
            prova3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da prova 4");
            prova4 = float.Parse(Console.ReadLine());

            media = (prova1 + prova2 + prova3 + prova4) / 4; 

            Console.WriteLine($"a media é {Math.Round(media,2)}");
            Console.ReadKey();

        }
    }
}
