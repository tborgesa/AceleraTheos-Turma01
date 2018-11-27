using Escola.Dominio.Professores;
using Escola.Dominio.Professores.Enumerador;
using Escola.Comum.Helpers;
using System;

namespace Escola.ConsoleApp
{
    public class Program
    {
        public static Professor _professor;
        public static EnumFormacao _formacao;
        public static EnumRegimeTrabalho _regimeTrabalho;

        static void Main(string[] args)
        {
            _professor = CadastrarProfessor();

            _professor.CalcularSalario();

            Console.Clear();

            Console.WriteLine($"***** DADOS DO PROFESSOR CADASTRADO *****" +
                $"\n\nNome: {_professor.Nome}" +
                $"\nRegime de Trabalho: {_professor.RegimeTrabalho}" +
                $"\nSalário: R${_professor.Salario}");

            Console.ReadKey();
        }

        public static Professor CadastrarProfessor()
        {

            InstanciarRegimeTrabalho();

            switch (_regimeTrabalho)
            {
                case EnumRegimeTrabalho.Horista:

                    CadastrarProfessorHorista();

                    break;

                case EnumRegimeTrabalho.Contratado:

                    CadastrarProfessorContratado();

                    break;

                default:
                    break;
            }

            return _professor;
        }

        private static void CadastrarProfessorContratado()
        {
            Console.Write("Informe o nome do professor: ");
            string nomeProfessorContratado = Console.ReadLine();

            _formacao = InstanciarFormacao();

            _professor = new ProfessorContratado(nomeProfessorContratado, _regimeTrabalho, _formacao);
        }

        private static Professor CadastrarProfessorHorista()
        {
            Console.Write("Informe o nome do professor: ");
            string nomeProfessorHorista = Console.ReadLine();

            double cargaHoraria = InputHelper.GetInputDouble(
                $"Informe a carga horária do para cálculo do salário do(a) Professor(a): {nomeProfessorHorista}",
                "Você digitou um valor inválido, tente novamente");

            _professor = new ProfessorHorista(nomeProfessorHorista, _regimeTrabalho, cargaHoraria);

            return _professor;
        }

        private static EnumRegimeTrabalho InstanciarRegimeTrabalho()
        {
            _regimeTrabalho = (EnumRegimeTrabalho)InputHelper.GetInputInt("Informe o Regime de Trabalho do Professor:" +
                "\n1 - Horista;" +
                "\n2 - Contratado;" +
                "\n\nDigite a opção abaixo:", "Opção Inválida");

            Console.Clear();

            return _regimeTrabalho;
        }

        private static EnumFormacao InstanciarFormacao()
        {
            bool opcao = true;
            while (opcao)
            {
               EnumFormacao formacao = (EnumFormacao)InputHelper.GetInputInt($"Escolha uma das opções para informar a formação acadêmica do(a) Professor(a):" +
               $"\n\n1 - Segundo Grau;" +
               $"\n2 - Graduado;" +
               $"\n3 - Mestre;" +
               $"\n4 - Doutor;" +
               $"\nInforme a formação abaixo:",
               "Você escolheu uma opção inválida!");

                if ((int)formacao > 4 || (int)formacao == 0)
                {
                    Console.WriteLine("Você escolheu uma opção errada!");
                }
                else
                {
                    _formacao = formacao;
                    opcao = false;
                }

                Console.WriteLine(formacao);
                Console.ReadKey();
            }
            return _formacao;
        }
    }

    
}
