using System;
using System.Collections.Generic;
using Theos.SistemaEscolar.Comum;
using Theos.SistemaEscolar.Dominio.Enumerador;
using Theos.SistemaEscolar.Dominio.Professor;

namespace Theos.SistemaEscolar
{
    class Program
    {
        private static string _nome;
        private static string _cpf;
        private static int _horasTrabalhadas;
        private static EEscolaridade _escolaridade;
       // private static Professor _professor = null;
        private static List<Professor> _listaProfessor = new List<Professor>();

        static void Main(string[] args)
        {
           

          


            Console.ReadKey();
        }

        private static Professor CriarProfessor()
        {
            Professor professor = null;

            //todo fazer while 
            int opcao = InputHelper.GetInputInt(@"Qual tipo de professor deseja calcular o salário?
Digite 1 para Professor Contratado
Digite 2 para Professor Horista", "Entrada inválida");


            switch (opcao)
            {
                case 1:
                    SolicitarInformacoesProfessorContratado();
                    MenuEscolaridadeProfessorContratado();
                    professor = new ProfessorContratado(_nome, _cpf, _escolaridade);
                    break;
                case 2:
                    SolicitarInformacoesProfessorHorista();
                    professor = new ProfessorHorista(_nome, _cpf, _horasTrabalhadas);
                    break;
                default:
                    InputHelper.MensagemUsuario("Opção inválida, escolha uma opção válida");
                    Console.ReadKey();
                    ;


            }

            //todo condição de parada falsa do while para sair do cadastro

            decimal valorSalario = professor.CalcularSalario();

            Console.Clear();
            InputHelper.MensagemUsuario($@"Nome do professor(a): {_nome} 
CPF: {_cpf} 
Salário: {valorSalario:c}");

            return professor;

        }


        private static void MenuProfessor()
        {
            int opcao = InputHelper.GetInputInt(@"Escolha uma das opções: 
1- Cadastrar
2- Listar todos
3- Ordenar por CPF
4- Ordenar por Nome
5- Sair", "Entrada inválida");

            switch (opcao)
            {
                case 1:
                    _listaProfessor.Add(CriarProfessor());
                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    return;

            }
        }
        private static void MenuEscolaridadeProfessorContratado()
        {
            _escolaridade = (EEscolaridade)InputHelper.GetInputInt(@"Escolha a escolaridade do professor contratado: 
Segundo Grau = 1,
Ensino Superior = 2,
Mestrado = 3,
Doutorado = 4 ", "Entrada inválida");
        }

        private static void SolicitarInformacoesProfessorContratado()
        {
            Console.WriteLine("Informe o nome do professor(a)");
            _nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF do professor(a)");
            _cpf = Console.ReadLine();
        }

        private static void SolicitarInformacoesProfessorHorista()
        {
            Console.WriteLine("Informe o nome do professor(a)");
            _nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF do professor(a)");
            _cpf = Console.ReadLine();
            _horasTrabalhadas = InputHelper.GetInputInt("Digite a quantidade de horas trabalhadas", "Entrada inválida");
        }

    }
}
