using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1) Monte um algoritimo que le 10 dados de alunos: Nome, Numero Matricula, Peso, Altura.
            //No final apresente:
            //       - Aluno(Matricula - Nome) com maior altura.
            //       - Aluno(Matricula - Nome) com menor altura.
            //       - Aluno(Matricula - Nome) com maior peso.
            //       - Aluno(Matricula - Nome) com menor peso.
            //       - Média do peso
            //       - Média da altura

            string nomeMatricula,nomeMenorPeso="",nomeMaiorPeso="",nomeMaiorAltura="",nomeMenorAltura="";
            double peso = 0,menorPeso=9999999999,maiorPeso= 0,altura=0,menorAltura=9999999999,maiorAltura=0,mediaPeso=0,mediaAltura=0;
            

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite nome");
                nomeMatricula = Console.ReadLine();

                Console.WriteLine("Digite peso");
                peso = Convert.ToDouble(Console.ReadLine());
                mediaPeso = mediaPeso + peso;

                Console.WriteLine("Digite altura");
                altura = Convert.ToDouble(Console.ReadLine());
                mediaAltura = mediaAltura + altura;
                Console.Clear();
                if (peso>maiorPeso)
                {
                    nomeMaiorPeso = nomeMatricula;
                    maiorPeso = peso;
                }

                if (peso<menorPeso)
                {
                    nomeMenorPeso = nomeMatricula;
                    menorPeso = peso;
                }

                if (altura>maiorAltura)
                {
                    nomeMaiorAltura = nomeMatricula;
                    maiorAltura = altura;
                }

                if (altura<menorAltura)
                {
                    nomeMenorAltura = nomeMatricula;
                    menorAltura = altura;
                }


            }
            mediaPeso = mediaPeso / 3;
            mediaAltura = mediaAltura / 3;
            Console.WriteLine($"Menor peso é :{menorPeso} do {nomeMenorPeso} \nMaior peso é :{maiorPeso} do {nomeMaiorPeso} \nMedia do peso é :{mediaPeso:n2}");
            Console.WriteLine($"Menor altura é :{menorAltura} do {nomeMenorAltura} \nMaior altura é :{maiorAltura} do {nomeMaiorAltura} \nMedia do altura é :{mediaAltura:n2}");
            Console.ReadKey();
        }
    }
}
