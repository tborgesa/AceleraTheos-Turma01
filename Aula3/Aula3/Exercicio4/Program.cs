using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Calcular a media final de um aluno, sabendo que ele realizou quatro provas no ano.
                    // 1. Solicitar a nota de cada prova.
                    //2. Solicitar o nome do aluno para apresentar na mensagem final.
                    //OBS: Deve ser arredondado (Math.Round) e apresentar apenas a parte inteira da nota.


            Console.WriteLine("por favor, Informe seu nome para continuar.");
            string nome = Console.ReadLine();

            Console.WriteLine("por favor, Informe a sua nota na primeira prova");
            double primeiraProva = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("por favor, Informe a sua nota na segunda prova");
            double segundaProva = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("por favor, Informe a sua nota na terceira prova");
            double terceiraProva = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("por favor, Informe a sua nota na quarta prova");
            double quartaProva = Convert.ToDouble(Console.ReadLine());


            double mediaFinal = (primeiraProva + segundaProva + terceiraProva + quartaProva) / 4;
            mediaFinal = Math.Round(mediaFinal);


            Console.WriteLine($"{nome}, a sua média final é {mediaFinal}.");

            if (mediaFinal > 7)
            {
                Console.WriteLine("Opá, Parabéns! continue assim.");
            }
            else
            {
                Console.WriteLine("Sinto muito! Quem sabe na próxima.");
            }


            Console.ReadKey();
        }
    }
}
