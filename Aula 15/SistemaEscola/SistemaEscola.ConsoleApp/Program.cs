using System;
using HelpersAlias = SistemaEscola.Comum.Helpers.InputHelper;
using SistemaEscola.Dominio.Escolaridade.Enumerador;
using SistemaEscola.Dominio.Funcionario;
using System.Collections.Generic;
using System.Linq;

/*
Considere um sistema para escola:

1. Nessa escola existe dois tipos de professores: contratado e horaista.

2. O sistema deverá calcular o salário de acordo com o professor:

Contratado: Fixo de acordo com a escolaridade
Segundo grau: R$ 1.000,00
Ensino Superior: R$ 1.800,00
Mestrado: R$ 3.000,00
Doutorado: R$ 5.000,00

Horista: R$ 17,00 por hora trabalhada
*/

namespace SistemaEscola.ConsoleApp
{
    class Program
    {
        public static List<Funcionario> funcionarios = new List<Funcionario>();
        public static string erro = "Valor Invalido!";
        public static string texto = "Digite uma opcao";
        public static string informeNome = "Informe o nome do professor:";

        static void Main(string[] args)
        {
            telaMenu();
            Console.ReadKey();
        }

        private static void telaMenu()
        {
            var opcao = HelpersAlias.GetInputInt(texto + "\n01 - Tipo funcionario\n" +
                "02 - Alterar\n" +
                "03 - Consulta\n" +
                "04 - Excluir\n" +
                "05 - Sair",erro);
            switch (opcao)
            {
                case 1:
                    TipoFuncionario();
                    break;
                case 2:
                    AlterarFuncionario();
                    break;
                case 3:
                    ConsultarFuncionario();
                    break;
                case 4:
                    ExcluirFuncionario();
                    break;
                case 5:
                    return;
                    break;
                default:
                    break;
            }

            telaMenu();
        }

        private static void ExcluirFuncionario()
        {
            throw new NotImplementedException();
        }

        private static void ConsultarFuncionario()
        {
            var nome = HelpersAlias.GetInputString("Digite o nome do professor:","Nome invalido");
            var funcionarioConsultado = funcionarios.FirstOrDefault(aluno => aluno.Nome == nome);
            if (funcionarioConsultado == null)
            {
                Console.WriteLine("Nome inválido");
            }
            else
            {
                Console.WriteLine($"Dados funcionário:\n" +
                    $"Nome: {funcionarioConsultado.Nome}\n" +
                    $"Cpf: {funcionarioConsultado.Cpf}" +
                    $"Salario: {funcionarioConsultado.SalarioFuncionario()}");
            }
            Console.ReadKey();
        }

        private static void TipoFuncionario()
        {
            var opcao = HelpersAlias.GetInputSwicth("Selecionar o tipo de professor \n" +
                "01 - Contratado \n" +
                "02 - Horista", erro, 1, 2);
            Console.WriteLine();
            switch (opcao)
            {
                case 1:
                    ProfessorContratado();
                    break;
                case 2:
                    ProfessorHorista();
                    break;
            }
        }

        private static void AlterarFuncionario()
        {
            var nomeFuncionario = HelpersAlias.GetInputString("Digite o nome do professor",erro);

            var funcionarioEncontrado = funcionarios.FirstOrDefault(aluno => aluno.Nome == "asdas");

            funcionarios.Remove(funcionarioEncontrado);
        }

        private static void ProfessorHorista()
        {
            var nome = HelpersAlias.GetInputString("Insira o Nome do professor", erro);
            var cpf = HelpersAlias.GetInputString("Insira o Cpf do professor", erro);
            var horas = HelpersAlias.GetInputInt("Insira as horas do professor",erro);

            funcionarios.Add(new Horaista(nome, cpf, horas));
            foreach (Funcionario professor in funcionarios)
            {
                var horistaProfessor = professor as Horaista;
                Console.WriteLine($"{horistaProfessor.Nome} " +
                    $"- {horistaProfessor.Cpf} " +
                    $"- {horistaProfessor.SalarioFuncionario()}");
            }
        }
        private static void ProfessorContratado()
        {
            var nome = HelpersAlias.GetInputString("Insira o Nome do professor", erro);
                EEscolaridade escolaridadeEscolhe;
            var cpf = HelpersAlias.GetInputString("Insira o Cpf do professor", erro);

            var opcao = HelpersAlias.GetInputSwicth("Insira o grau de escolariedade do professor\n" +
                    "1 - Doutorado\n" +
                    "2 - Ensino Superior\n" +
                    "3- Mestrado\n" +
                    "4- Segundo Grau\n", erro, 1, 4);

                switch (opcao)
                {
                    case 1:
                        escolaridadeEscolhe = EEscolaridade.Doutorado;
                        funcionarios.Add(new Contratado(nome, cpf, escolaridadeEscolhe));
                        break;
                    case 2:
                        escolaridadeEscolhe = EEscolaridade.EnsinoSuperior;
                        funcionarios.Add(new Contratado(nome, cpf, escolaridadeEscolhe));
                        break;
                    case 3:
                        escolaridadeEscolhe = EEscolaridade.Mestrado;
                        funcionarios.Add(new Contratado(nome, cpf, escolaridadeEscolhe));
                        break;
                    case 4:
                        escolaridadeEscolhe = EEscolaridade.SegudundoGrau;
                        funcionarios.Add(new Contratado(nome, cpf, escolaridadeEscolhe));
                        break;
                    default:
                        Console.WriteLine(erro);
                        break;

                }
                foreach (Funcionario professor in funcionarios)
                {
                    var contratadoProfessor = professor as Contratado;
                    Console.WriteLine($"{contratadoProfessor.Nome} " +
                        $"- {contratadoProfessor.Escolaridade.EscolariadadeDescricao} " +
                        $"- {contratadoProfessor.Escolaridade.Salario}");
                }
            }

    }
}