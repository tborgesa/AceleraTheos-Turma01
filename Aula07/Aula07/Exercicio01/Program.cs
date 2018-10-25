using System;
using Exercicio01.Helpers;

namespace Exercicio01
{
    class Program
    {
        static string nome, matricula = "";
        static double peso, altura = 0.0;
        private static string _mensagemInvalida = "Entrada inválida, tente novamente.";
        static double _pesoGuardado = 0.0;
        static double _alturaGuardada = 0.0;
        static void Main(string[] args)
        {
            InserirAluno();
            CalcularAltura();
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

                ValidarPeso();
                ValidarAltura();

            }

            Console.WriteLine($@"Nome: {nome}
Matrícula: {matricula}
Peso: {peso:N2}kg
Altura: {altura}");
            Console.ReadKey();
        }

        private static void ValidarPeso()
        {
            if (_pesoGuardado < peso)
                _pesoGuardado += peso;
        }

        private static void ValidarAltura()
        {
            if (_alturaGuardada < altura)
                _alturaGuardada += peso;
        }
        private static void CalcularAltura()
        {
            double resultadoAltura = 0.0;
            ValidarAltura();


            Console.WriteLine($"Resultado: {_pesoGuardado} e {_alturaGuardada}");
            Console.ReadKey();
        }
    }
}
