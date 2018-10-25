using System;

namespace Exercicio01
{
    class Program
    {
        static string _qtdCadastroAluno = null,
                      _alunoNome = null,
                      _alunoNomeMaiorAltura = null,
                      _alunoNomeMenorAltura = null,
                      _alunoNomeMaiorPeso = null,
                      _alunoNomeMenorPeso = null;

        static int _id = 1,
                   _alunoMatricula = 0,
                   _alunoMatriculaMaiorAltura = 0,
                   _alunoMatriculaMenorAltura = 0,
                   _alunoMatriculaMaiorPeso = 0,
                   _alunoMatriculaMenorPeso = 0;

        static decimal _alunoAltura = 0,
                       _maiorAltura = 0,
                       _menorAltura = 0,
                       _somaAltura = 0,
                       _alunoPeso = 0,
                       _maiorPeso = 0,
                       _menorPeso = 0,
                       _somaPeso = 0;

        static void Main(string[] args)
        {
            /*
             1) Monte um algoritimo que le 10 dados de alunos: Nome, Numero Matricula, Peso, Altura.

                No final apresente:
                - Aluno (Matricula - Nome) com maior altura.
                - Aluno (Matricula - Nome) com menor altura.
                - Aluno (Matricula - Nome) com maior peso.
                - Aluno (Matricula - Nome) com menor peso.
                - Média do peso
                - Média da altura
             */

            Console.Clear();

            Console.WriteLine("Digite quantos alunos deseja cadastrar:");
            _qtdCadastroAluno = Console.ReadLine();

            if (int.TryParse(_qtdCadastroAluno, out int numero))
            {
                while (_id <= numero)
                {
                    Console.Clear();

                    Console.WriteLine($"\nDigite o nome do aluno {_id}:");
                    _alunoNome = Console.ReadLine();

                    Console.WriteLine($"\nDigite o número da matrícula {_id}:");
                    _alunoMatricula = int.Parse(Console.ReadLine());

                    Console.WriteLine($"\nDigite o peso do aluno {_id}:");
                    _alunoPeso = decimal.Parse(Console.ReadLine());

                    Console.WriteLine($"\nDigite a altura do aluno {_id}:");
                    _alunoAltura = decimal.Parse(Console.ReadLine());


                    if (_alunoAltura > _maiorAltura)
                    {
                        _maiorAltura = _alunoAltura;
                        _alunoNomeMaiorAltura = _alunoNome;
                        _alunoMatriculaMaiorAltura = _alunoMatricula;
                    }

                    if (_id == 1 || _alunoAltura < _menorAltura)
                    {
                        _menorAltura = _alunoAltura;
                        _alunoNomeMenorAltura = _alunoNome;
                        _alunoMatriculaMenorAltura = _alunoMatricula;
                    }

                    if (_alunoPeso > _maiorPeso)
                    {
                        _maiorPeso = _alunoPeso;
                        _alunoNomeMaiorPeso = _alunoNome;
                        _alunoMatriculaMaiorPeso = _alunoMatricula;
                    }

                    if (_id == 1 || _alunoPeso < _menorPeso)
                    {
                        _menorPeso = _alunoPeso;
                        _alunoNomeMenorPeso = _alunoNome;
                        _alunoMatriculaMenorPeso = _alunoMatricula;
                    }

                    _somaPeso += _alunoPeso;
                    _somaAltura += _alunoAltura;

                    _id++;
                }
            }
            else
            {
                Console.WriteLine("Número digitado inválido!");
                Console.ReadKey();
            }

            MostrarEstatistica();
        }

        private static void MostrarEstatistica()
        {
            Console.Clear();

            Console.WriteLine($"\n\nAluno ({_alunoMatriculaMaiorAltura} - {_alunoNomeMaiorAltura}) com maior altura");
            Console.WriteLine($"\nAluno ({_alunoMatriculaMenorAltura} - {_alunoNomeMenorAltura}) com menor altura");

            Console.WriteLine($"\n\nAluno ({_alunoMatriculaMaiorPeso} - {_alunoNomeMaiorPeso}) com maior peso");
            Console.WriteLine($"\nAluno ({_alunoMatriculaMenorPeso} - {_alunoNomeMenorPeso}) com menor peso");

            Console.WriteLine($"\n\nMédia do peso dos alunos: {_somaPeso / int.Parse(_qtdCadastroAluno):N2}kg.");
            Console.WriteLine($"\nMédia da altura dos alunos: {_somaAltura / int.Parse(_qtdCadastroAluno):N2}m.");

            Console.ReadKey();
        }
    }
}
