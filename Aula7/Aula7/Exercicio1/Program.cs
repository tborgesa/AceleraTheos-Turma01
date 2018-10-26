using System;

namespace Exercicio1
{
    public class Program
    {
        static double _maiorPeso = 0;
        static double ? _menorPeso;
        static double _maiorAltura = 0;
        static double ? _menorAltura;
        static string _nomeMaiorPeso;
        static string _nomeMaiorAltura;
        static string _nomeMenorAltura;
        static string _nomeMenorPeso;
        static double _mediaAltura;
        static double _mediaPeso;

        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 3)
            {
                Console.Clear();
                Console.WriteLine($"Digite as informações da pessoa {i}.");

                Console.WriteLine("Qual seu Nome?");
                string nome = Console.ReadLine();
                string.IsNullOrWhiteSpace(nome);

                Console.WriteLine("Qual a numeração da sua Matricula?");
                int matricula = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe seu peso.");
                double peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe sua altura.");
                double altura = double.Parse(Console.ReadLine());

                MaiorPeso(peso, nome);
                MenorPeso(peso, nome);
                MaiorAltura(altura, nome);
                MenorAltura(altura, nome);
                MediaPeso(peso);
                MediaAltura(altura);

                i++;
            }

            Console.WriteLine($"A maior altura é de {_nomeMaiorAltura} com {_maiorAltura} cm.");
            Console.WriteLine($"A menor altura é de {_nomeMenorAltura} com {_menorAltura} cm.");

            Console.WriteLine($"O menor peso é de {_nomeMenorPeso} com {_menorPeso} kg.");
            Console.WriteLine($"O maior peso é de {_nomeMaiorPeso} com {_maiorPeso} kg.");

            _mediaAltura = _mediaAltura / 3;
            Console.WriteLine($"Média da altura é {_mediaAltura:N2} cm");

            _mediaPeso = _mediaPeso / 3;
            Console.WriteLine($"Média do peso é {_mediaPeso:N2} kg");

            Console.ReadKey();


        }

        private static void MediaAltura(double altura)
        {
            _mediaAltura = _mediaAltura + altura;

        }


        private static void MediaPeso(double peso)
        {
            _mediaPeso = _mediaPeso + peso;

        }

        private static void MenorAltura(double altura, string nome)
        {
            if (_menorAltura == null)
            {
                _menorAltura = altura;
                _nomeMenorAltura = nome;
            }
            else if (altura < _menorAltura)
            {
                _menorAltura = altura;
                _nomeMenorAltura = nome;
            }
                
        }

        private static void MaiorAltura(double altura, string nome)
        {
            if (altura > _maiorAltura)
            {
                _maiorAltura = altura;
                _nomeMaiorAltura = nome;
            }
        }

        private static void MenorPeso(double peso, string nome)
        {
            if (_menorPeso == null)
            {
                _menorPeso = peso;
                _nomeMenorPeso = nome;
            }
            else if (peso < _menorPeso)
            {
                _menorPeso = peso;
                _nomeMenorPeso = nome;
            }
        }

        private static void MaiorPeso(double peso, string nome)
        {
            if (peso > _maiorPeso)
            {
                _maiorPeso = peso;
                _nomeMaiorPeso = nome;
            }
        }

    }
}
