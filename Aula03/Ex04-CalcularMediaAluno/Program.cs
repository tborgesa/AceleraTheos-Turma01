using System;


namespace Ex04_CalcularMediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular média do aluno\n");

            double nota1, nota2, nota3, nota4;
            double media = 0.0;

            Console.WriteLine("Informe a primeira nota do aluno");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota do aluno");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota do aluno");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quarta nota do aluno");
            nota4 = double.Parse(Console.ReadLine());
            
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine($"A média do aluno é: {Math.Round(media)}");

            Console.ReadKey();
       
        }
    }
}
