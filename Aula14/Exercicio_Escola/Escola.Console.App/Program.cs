using Escola.Dominio.Professores;
using Escola.Dominio.Professores.Enumerador;
using Escola.Comum.Helpers;
using System;

namespace Escola.ConsoleApp
{
    class Program
    {
        public static Professor _professor;

        static void Main(string[] args)
        {
            _professor = CadastrarProfessor();
            _professor.CalcularSalario();

            Console.WriteLine($"***** DADOS DO PROFESSOR CADASTRADO *****" +
                $"\n\nNome: {_professor.Nome}" +
                $"\nRegime de Trabalho: {_professor.RegimeTrabalho}" +
                $"\nSalário: R${_professor.Salario}");

            Console.ReadKey();
        }

        public static Professor CadastrarProfessor()
        {
            EnumRegimeTrabalho regimeTrabalho = (EnumRegimeTrabalho)InputHelper.GetInputInt("Informe o Regime de Trabalho do Professor:" +
                "\n1 - Horista;" +
                "\n2 - Contratado;" +
                "\n\nDigite a opção abaixo:", "Opção Inválida");

            Console.Clear();

            switch (regimeTrabalho)
            {
                case EnumRegimeTrabalho.Horista:
                    Console.Write("Informe o nome do professor: ");
                    string nomeProfessorHorista = Console.ReadLine();

                    double cargaHoraria = InputHelper.GetInputDouble(
                        $"Informe a carga horária do para cálculo do salário do(a) Professor(a): {nomeProfessorHorista}",
                        "Você digitou um valor inválido, tente novamente");

                    _professor = new ProfessorHorista(nomeProfessorHorista, regimeTrabalho, cargaHoraria);

                    break;

                case EnumRegimeTrabalho.Contratado:

                    Console.Write("Informe o nome do professor: ");

                    bool opcao = true;
                    while (opcao)
                    {
                        EnumFormacao formacao = (EnumFormacao)InputHelper.GetInputInt($"Escolha uma das opções para informar a formação acadêmica do(a) Professor(a) {nomeProfessorContratado}:" +
                       $"\n\n1 - Segundo Grau;" +
                       $"\n2 - Graduado;" +
                       $"\n3 - Mestre;" +
                       $"\n4 - Doutor;" +
                       $"\nInforme a formação abaixo:",
                       "Você escolheu uma opção inválida!");

                        if((int)formacao > 4 || (int) formacao == 0)
                        {
                            Console.WriteLine("Você escolheu uma opção errada!");
                            
                        
                    }
                    string nomeProfessorContratado = Console.ReadLine();
                    EnumFormacao formacao = (EnumFormacao)InputHelper.GetInputInt($"Escolha uma das opções para informar a formação acadêmica do(a) Professor(a) {nomeProfessorContratado}:" +
                        $"\n\n1 - Segundo Grau;" +
                        $"\n2 - Graduado;" +
                        $"\n3 - Mestre;" +
                        $"\n4 - Doutor;" +
                        $"\nInforme a formação abaixo:",
                        "Você escolheu uma opção inválida!");

                    

                    _professor = new ProfessorContratado(nomeProfessorContratado, regimeTrabalho, formacao);

                    break;

                default:
                    break;
            }

            return _professor;
        }

    }

    
}
