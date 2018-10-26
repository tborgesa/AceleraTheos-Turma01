using System;

/*1) Monte um algoritimo que le 10 dados de alunos: Nome, Numero Matricula, Peso, Altura.

No final apresente:
- Aluno (Matricula - Nome) com maior altura.
- Aluno (Matricula - Nome) com menor altura.
- Aluno (Matricula - Nome) com maior peso.
- Aluno (Matricula - Nome) com menor peso.
- Média do peso
- Média da altura*/

namespace Exercicio01
{
    public class aluno
    {
        public string nome = " ";
        public int matricula = 0;
        public double peso = 0;
        public double altura = 0;
    }

    class Program
    {

        static double totalPeso = 0;
        static double totalAltura = 0;

        static void Main(string[] args)
        {
            var maiorAltura = new aluno();
            var menorAltura = new aluno();
            var maiorPeso = new aluno();
            var menorPeso = new aluno();

            var sala = new aluno[10];

            for (int i = 0; i <= 9; i++)
            {
                var alunos = new aluno();
                Console.Clear();

                Console.WriteLine("Digite o nome do Aluno");
                alunos.nome = Console.ReadLine();

                Console.WriteLine("Digite a Matricula");
                alunos.matricula = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do Peso");
                alunos.peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do Altura");
                alunos.altura = double.Parse(Console.ReadLine());

                sala[i] = alunos;

                if (menorAltura.altura == 0) {
                    menorAltura = sala[i];
                    menorPeso = sala[i];
                }

                if (maiorAltura.altura < sala[i].altura)
                {
                    maiorAltura = sala[i];
                }
                if (menorAltura.altura > sala[i].altura)
                {
                    menorAltura = sala[i];
                }

                totalAltura += sala[i].peso;

                if (maiorPeso.peso < sala[i].peso)
                {
                    maiorPeso = sala[i];
                }
                if (menorPeso.peso > sala[i].peso)
                {
                    menorPeso = sala[i];
                }

                totalPeso += sala[i].peso;
            }

            Console.Clear();

            Console.WriteLine($"No final apresente\n");

            Console.WriteLine($"- Aluno({maiorAltura.matricula} - {maiorAltura.nome}) com maior altura.");
            Console.WriteLine($"- Aluno({menorAltura.matricula} - {menorAltura.nome}) com menor altura.");
            Console.WriteLine($"- Aluno({maiorPeso.matricula} - {maiorPeso.nome}) com maior peso.");
            Console.WriteLine($"- Aluno({menorPeso.matricula} - {menorPeso.nome}) com menor peso.");
            Console.WriteLine($"- Média do peso {medioPeso(totalPeso):n2}");
            Console.WriteLine($"- Média da altura {medioAltura(totalAltura):n2}");

            Console.ReadKey();
        }

        private static double medioPeso(double valor)
        {
            return valor/10;
        }

        private static double medioAltura(double valor)
        {
            return valor /10;
        }
    }
}
