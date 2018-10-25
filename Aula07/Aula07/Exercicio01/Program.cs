using System;
using Exercicio01.Helpers;

namespace Exercicio01
{
    class Program
    {
        static string nome, matricula = "";
        static double peso, altura = 0.0;
        private static string _mensagemInvalida = "Entrada inválida, tente novamente.";
        static void Main(string[] args)
        {
            InserirAluno();
        }

        private static void InserirAluno()
        {
            for (int i = 0; i <= 10; i++)
            {

                nome = InputHelper.GetInputString("Digite o nome: ", _mensagemInvalida);
                matricula = InputHelper.GetInputString("Digite a matricula: ", _mensagemInvalida);
                peso = InputHelper.GetInputDouble("Digite o peso: ", _mensagemInvalida);
                altura = InputHelper.GetInputDouble("Digite a altura: ", _mensagemInvalida);
                Console.WriteLine();
            }

            Console.WriteLine($@"Nome: {nome}
Matrícula: {matricula}
Peso: {peso:N2}kg
Altura: {altura}");
            Console.ReadKey();
        }

    }
}
