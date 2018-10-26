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
        static string _mensagemInvalida = "O valor digitado é inválido. Tente novamente!";
        static string _nomeMaiorPeso;
        static string _nomeMenorPeso;
        static string _nomeMaiorAltura;
        static string _nomeMenorAltura;
        static double _matriculaMaiorPeso;
        static double _matriculaMenorPeso;
        static double _matriculaMaiorAltura;
        static double _matriculaMenorAltura;
        static double _maiorPeso;
        static double? _menorPeso;
        static double _maiorAltura;
        static double? _menorAltura;
        static double _mediaPeso;
        static double _mediaAltura;

        static void Main(string[] args)
        {   
            for(int i=1; i<12; i++)
            {
                Console.WriteLine("Informe o nome do aluno: ");
                string nome = Console.ReadLine();

                double matricula = InputHelper.GetInputDouble("Digite a matrícula do aluno: ", _mensagemInvalida);
                double peso = InputHelper.GetInputDouble("Digite o peso do(a) aluno(a): ", _mensagemInvalida);
                double altura = InputHelper.GetInputDouble("Digite a altura do aluno: ", _mensagemInvalida);

                ValidarMaiorPeso(peso, nome, matricula);
                ValidarMenorPeso(peso, nome, matricula);
                ValidarMenorAltura(altura, nome, matricula);
                ValidarMaiorAltura(altura, nome, matricula);

                _mediaAltura = (_mediaAltura + altura)/i;
                _mediaPeso = (_mediaPeso + peso) / i;

                Console.Clear();

            }

            Console.WriteLine($"Aluno com maior peso: {_nomeMaiorPeso} - Matrícula: {_matriculaMaiorPeso} - Peso: {_maiorPeso}kg");
            Console.WriteLine($"Aluno com menor peso: {_nomeMenorPeso} - Matrícula: {_matriculaMenorPeso} - Peso: {_menorPeso}kg");
            Console.WriteLine($"Aluno com maior altura: {_nomeMaiorAltura} - Matrícula: {_matriculaMenorAltura} - Peso: {_menorAltura}m");
            Console.WriteLine($"Aluno com menor altura: {_nomeMenorAltura} - Matrícula: {_matriculaMaiorAltura} - Peso: {_maiorAltura}m");
            Console.WriteLine($"A média de peso dos alunos é: {_mediaPeso:n2}kg");
            Console.WriteLine($"A média da altura dos alunos é: {_mediaAltura:n2}m");

            Console.ReadKey();
        }

        private static void ValidarMaiorAltura(double altura, string nome, double matricula)
        {
            if(altura > _maiorAltura)
            {
                _maiorAltura = altura;
                _matriculaMaiorAltura = matricula;
                _nomeMaiorAltura = nome;
            }
        }

        private static void ValidarMenorAltura(double altura, string nome, double matricula)
        {
            if(_menorAltura == null || altura < _menorAltura)
            {
                _menorAltura = altura;
                _matriculaMenorAltura = matricula;
                _nomeMenorAltura = nome;
            }
        }

        private static void ValidarMenorPeso(double peso, string nome, double matricula)
        {
            if(_menorPeso == null ||  peso < _menorPeso.Value)
            {
                _menorPeso = peso;
                _matriculaMenorPeso = matricula;
                _nomeMenorPeso = nome;
            }
        }

        static void ValidarMaiorPeso(double peso, string nome, double matricula)
        {
            if (peso > _maiorPeso)
            {
                _maiorPeso = peso;
                _matriculaMaiorPeso = matricula;
                _nomeMaiorPeso = nome;
            }
        }
    }
}
