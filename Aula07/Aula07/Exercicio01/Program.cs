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
        static double _maiorPeso = 0.0;
        static double _menorPeso = 0.0;
        static double _maiorAltura = 0.0;
        static double _menorAltura = 0.0;
        static double _mediaAltura = 0.0;
        static double _mediaPeso = 0.0;

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
           
            if(_alturaGuardada )


            Console.WriteLine($"Resultado: {_pesoGuardado} e {_alturaGuardada}");
            Console.ReadKey();
        }

        private static void ImprimirResultado()
        {
            Console.WriteLine($@"Nome: {nome}
Matrícula: {matricula}
Maior peso: {_maiorPeso}kg
Menor peso: {_menorPeso}kg
Maior altura: {_maiorAltura}
Menor altura: {_menorAltura}
Média de peso: {_mediaPeso}
Média de altura: {_mediaAltura}");
            Console.ReadKey();
        }
    }
}
