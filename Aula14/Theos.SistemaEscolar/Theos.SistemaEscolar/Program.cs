using System;
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

        static void Main(string[] args)
        {
            Professor professor = null;

            int opcao = InputHelper.GetInputInt(@"Qual tipo de professor deseja calcular o salário?
Digite 1 para Professor Contratado
Digite 2 para Professor Horista
Digite 3 para sair", "Entrada inválida");

            switch (opcao)
            {
                case 1:
                    SolicitarInformacoesProfessorContratado();
                    MenuProfessorContratado();
                    professor = new ProfessorContratado(_nome, _cpf, _escolaridade);
                    break;
                case 2:
                    SolicitarInformacoesProfessorHorista();
                    professor = new ProfessorHorista(_nome, _cpf, _horasTrabalhadas);
                    break;
                case 3:
                    InputHelper.MensagemUsuario("Você escolheu sair! Saindo do sistema...");
                    Console.ReadKey();
                    return;
                default:
                    InputHelper.MensagemUsuario("Opção inválida, escolha uma opção válida");
                    Console.ReadKey();
                    return;

                 
            }

            decimal valorSalario = professor.CalcularSalario();

            Console.Clear();
            InputHelper.MensagemUsuario($@"Nome do professor(a): {_nome} 
CPF: {_cpf} 
Salário: {valorSalario:c}");

           
            Console.ReadKey();
        }

        private static void MenuProfessorContratado()
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
