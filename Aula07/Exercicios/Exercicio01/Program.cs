using System;
using Exercicio01.Helpers;
/*1) Monte um algoritimo que le 10 dados de alunos: Nome, Numero Matricula, Peso, Altura.
No final apresente:
- Aluno(Matricula - Nome) com maior altura.
- Aluno(Matricula - Nome) com menor altura.
- Aluno(Matricula - Nome) com maior peso.
- Aluno(Matricula - Nome) com menor peso.
- Média do peso
- Média da altura */
namespace Exercicio01
{
    class Program
    {
        static double _matricula;

        static void Main(string[] args)
        {
            Console.WriteLine("Exercicío 01 - Matrículas");
            Console.WriteLine();

            Console.WriteLine("Informe o nome do aluno:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o número da matrícula do aluno:");
            double matricula = InputGetDouble();

            Console.WriteLine("Informe o peso do aluno: ");
            double peso = InputGetDouble();

            Console.WriteLine($"Nome: {nome} - Matricula: {matricula} - Peso: {peso}");
            Console.ReadKey();
        }

        public static double InputGetDouble()
        {
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out double numero))
                {
                    Console.WriteLine("Você digitou um valor inválido. Tente novamente!");
                    Console.ReadKey();
                }
                else
                    return numero;
            }
        }
    }
}
