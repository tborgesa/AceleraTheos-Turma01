using Escola.Dominio.Professores;
using Escola.Dominio.Professores.Enumerador;
using Escola.Comum.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Escola.ConsoleApp
{
    public class Program
    {
        public static Professor _professor;
        public static EnumFormacao _formacao;
        public static EnumRegimeTrabalho _regimeTrabalho;
        public static List<Professor> _professores = new List<Professor>();

        static void Main(string[] args)
        {

            while (true)
            {
                int opcao = MenuPrincipal();

                if (opcao == 1)
                {
                    //Cadastrar Professor
                    _professor = CadastrarProfessor();
                    _professores.Add(_professor);

                }

                else if (opcao == 2)
                {
                    //Pesquisar cadastro de professor;
                    Console.Clear();

                    PesquisarProfessor();
                    Console.ReadKey();
                }

                else if (opcao == 3)
                {
                    //Consultar Salário;
                    Console.Clear();
                    ConsultarSalario();

                }

                else
                {
                    Console.Clear();
                    Console.Write("O sistema esta sendo encerrado...\n\nAperte qualquer tecla para fechar: ");
                    break;
                }

            }

            Console.ReadKey();
        }

        private static void PesquisarProfessor()
        {
            if (_professores.Count == 0)
            {
                Console.WriteLine("O sistema não possui professores cadastrados...");
                Console.ReadKey();
                return;
            }

            else
            {
                _professores = _professores.OrderBy(professor => professor.Nome).ToList();
                int numerador = _professores.Count;

                Console.WriteLine($"Foram encontrados {numerador} cadastro(s) de professor(es)\n");

                foreach (var professor in _professores)
                {
                    Console.WriteLine(professor.Nome);
                }

                Console.ReadKey();
                return;
            }

        }

        private static int MenuPrincipal()
        {
            while (true)
            {
                string menu = @"***** SISTEMA DE GESTÃO ESCOLAR *****

Escolha uma opção:
1 - Cadastrar professor;
2 - Listar professores cadastrados;
3 - Consultar Salário;
0 - SAIR

Digite sua escolha abaixo: ";
                Console.Clear();

                int opcao = InputHelper.GetInputInt(menu, "Opção Inválida");

                if (opcao > 3)
                {
                    Console.WriteLine("Opção Inválida, tente novamente!");
                    Console.ReadKey();
                }
                else
                {
                    return opcao;
                }
            }
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
            }
            return _formacao;
        }

        private static void ConsultarSalario()
        {
            Console.Clear();

            Console.Write("Digite o nome do professor para consultar o pagamento: ");
            string nomeProfessor = Console.ReadLine();

            foreach (var professor in _professores)
            {
                if(professor.Nome == nomeProfessor)
                {
                    professor.CalcularSalario();
                    Console.ReadKey();
                }
            }
        }
    }
}
