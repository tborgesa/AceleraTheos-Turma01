using System;
using Exercicio01.Helpers;

namespace Exercicio01
{
    class Program
    {
        static string _nomeMaiorAltura, _matriculaMaiorAltura, _nomeMenorAltura, _matriculaMenorAltura = "";
        static string _nomeMaiorPeso, _matriculaMaiorPeso, _nomeMenorPeso, _matriculaMenorPeso = "";
        static double _pesoAcumulado, _alturaAcumulado = 0.0;
        static double _maiorPeso = 0.0;
        static double? _menorPeso;
        static double _maiorAltura = 0.0;
        static double? _menorAltura;
        static double _mediaAltura = 0.0;
        static double _mediaPeso = 0.0;
        private static string _mensagemInvalida = "Entrada inválida, tente novamente.";

        static void Main(string[] args)
        {
            InserirAluno();
            CalcularMedia();
            ImprimirResultado();
        }

        private static void InserirAluno()
        {
            for (int i = 0; i < 3; i++)
            {

                string nome = InputHelper.GetInputString("Digite o nome: ", _mensagemInvalida);
                string matricula = InputHelper.GetInputString("Digite a matricula: ", _mensagemInvalida);
                double peso = InputHelper.GetInputDouble("Digite o peso: ", _mensagemInvalida);
                double altura = InputHelper.GetInputDouble("Digite a altura: ", _mensagemInvalida);
                Console.WriteLine();

                ValidarPeso(peso, nome, matricula);
                ValidarAltura(altura, nome, matricula);
            }
        }

        private static void ValidarPeso(double peso, string nome, string matricula)
        {
            if (peso > _maiorPeso)
            {
                _maiorPeso = peso;
                _nomeMaiorPeso = nome;
                _matriculaMaiorPeso = matricula;
            }
            if (_menorPeso == null || peso < _menorPeso.Value)
            {
                _menorPeso = peso;
                _nomeMenorPeso = nome;
                _matriculaMenorPeso = matricula;
            }

            _pesoAcumulado += peso;
        }

        private static void ValidarAltura(double altura, string nome, string matricula)
        {
            if (altura > _maiorAltura)
            {
                _maiorAltura = altura;
                _nomeMaiorAltura = nome;
                _matriculaMaiorAltura = matricula;
            }
            if (_menorAltura == null || altura < _menorAltura.Value)
            {
                _menorAltura = altura;
                _nomeMenorAltura = nome;
                _matriculaMenorAltura = matricula;
            }

            _alturaAcumulado += altura;
        }
        private static void CalcularMedia()
        {
            _mediaPeso += _pesoAcumulado / 3;
            _mediaAltura += _alturaAcumulado / 3;
        }

        private static void ImprimirResultado()
        {
            Console.WriteLine($@"{_matriculaMaiorPeso} - {_nomeMaiorPeso} possui maior peso: {_maiorPeso}kg 
{_matriculaMenorPeso} - {_nomeMenorPeso} possui menor peso: {_menorPeso}kg
{_matriculaMaiorAltura} - {_nomeMaiorAltura} possui maior altura: {_maiorAltura:N2}cm 
{_matriculaMenorAltura} - {_nomeMenorAltura} possui menor altura: {_menorAltura:N2}cm
Média de peso: {_mediaPeso:N2}kg
Média de altura: {_mediaAltura:N2}cm");
            Console.ReadKey();
        }
    }
}
