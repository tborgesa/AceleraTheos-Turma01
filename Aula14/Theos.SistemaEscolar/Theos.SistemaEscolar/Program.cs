using System;
using System.Collections.Generic;
using System.Linq;
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
        private static Professor _professor = null;
        private static List<Professor> _listaProfessor = new List<Professor>();

        static void Main(string[] args)
        {

            MenuProfessor();



            Console.ReadKey();
        }

        private static Professor CriarProfessor()
        {

            int sair = 1;

            while (sair != 0)
            {

                int opcao = InputHelper.GetInputInt(@"Qual tipo de professor deseja cadastrar no sistema?
Digite 1 para Professor Contratado
Digite 2 para Professor Horista", "Entrada inválida");

                switch (opcao)
                {
                    case 1:
                        SolicitarInformacoesProfessorContratado();
                        MenuEscolaridadeProfessorContratado();
                        _professor = new ProfessorContratado(_nome, _cpf, _escolaridade);
                        break;
                    case 2:
                        SolicitarInformacoesProfessorHorista();
                        _professor = new ProfessorHorista(_nome, _cpf, _horasTrabalhadas);
                        break;
                    default:
                        InputHelper.MensagemUsuario("Opção inválida, escolha uma opção válida");
                        Console.ReadKey();
                        break;
                }

                _listaProfessor.Add(_professor);

                sair = InputHelper.GetInputInt(@"Deseja cadastrar outro professor?
Sim - Digite 1
Não - Digite 0", "Entrada inválida");

            }

            MenuProfessor();
            return _professor;

        }

        private static void CalcularSalario()
        {
            string cpf = InputHelper.GetInputString("Digite o CPF do professor");

            Professor professoresFiltrados = _listaProfessor.FirstOrDefault(professor => professor.Cpf == cpf);

            if (professoresFiltrados == null)
                Console.WriteLine("CPF não encontrado.");
            else
                Console.WriteLine($"{professoresFiltrados.Nome} - {professoresFiltrados.CalcularSalario()}");

        }


        private static void MenuProfessor()

        {
            int opcao = InputHelper.GetInputInt(@"Escolha uma das opções: 
1- Cadastrar
2- Calcular salário
3- Listar todos
4- Ordenar por CPF
5- Ordenar por Nome
6- Sair", "Entrada inválida");

            switch (opcao)
            {
                case 1:
                    CriarProfessor();
                    break;
                case 2:
                    CalcularSalario();
                    break;
                case 3:
                    ListarTodos();
                    break;
                case 4:

                case 5:
                    break;
                case 6:
                    return;

            }

        }

        private static void ListarTodos()
        {
            Console.Clear();
            if (_listaProfessor.Count == 0)
                InputHelper.MensagemUsuario("Não existe nenhum professor cadastrado");
            foreach (var professor in _listaProfessor)
            {
                Console.WriteLine($@"Nome: {professor.Nome}
CPF: {professor.Cpf}");

            }
            Console.ReadKey();
            MenuProfessor();
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
