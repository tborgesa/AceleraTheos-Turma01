using System;
using HelpersAlias = SistemaEscola.Comum.Helpers.InputHelper;
using SistemaEscola.Dominio.Escolaridade.Enumerador;
using SistemaEscola.Dominio.Funcionario;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

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
        public static string erro = "Dado Invalido!";
        public static string removidoSucesso = "Removido com Sucesso!";
        public static string texto = "Digite uma opcao";
        public static string informeNome = "Informe o nome do professor:";

        static void Main(string[] args)
        {
            //telaMenu();
        }

        //private static void telaMenu()
        //{
        //    var opcao = HelpersAlias.GetInputInt(texto + "\n01 - Cadastro\n" +
        //        "02 - Alterar\n" +
        //        "03 - Consulta\n" +
        //        "04 - Excluir\n" +
        //        "05 - Listar\n" +
        //        "06 - Sair", erro);
        //    switch (opcao)
        //    {
        //        case 1:
        //            TipoFuncionario();
        //            break;
        //        case 2:
        //            AlterarFuncionario();
        //            break;
        //        case 3:
        //            ConsultarFuncionario();
        //            break;
        //        case 4:
        //            ExcluirFuncionario();
        //            break;
        //        case 5:
        //            ListaFuncionarios();
        //            break;
        //        case 6:
        //            return;
        //        default:
        //            break;
        //    }

        //    telaMenu();
        //}

        //private static void ProfessorHorista(string nome, string cpf)
        //{
        //    var horas = HelpersAlias.GetInputInt("Insira as horas do professor", erro);

        //        funcionarios.Add(new Horista(dataNascimento,nome,cpf,endereco,horas));
        //        HelpersAlias.PostString("Cadastrado com Sucesso!");
        //}

        //private static void ProfessorContratado(string nome, string cpf)
        //{
        //    EEscolaridade escolaridadeEscolhe;
        //    var opcao = HelpersAlias.GetInputSwicth("Insira o grau de escolariedade do professor\n" +
        //            "1 - Doutorado\n" +
        //            "2 - Ensino Superior\n" +
        //            "3- Mestrado\n" +
        //            "4- Segundo Grau\n", erro, 1, 4);
        //    switch (opcao)
        //    {
        //        case 1:
        //            escolaridadeEscolhe = EEscolaridade.Doutorado;
        //            funcionarios.Add(new Contratado(nome, cpf, escolaridadeEscolhe));
        //            break;
        //        case 2:
        //            escolaridadeEscolhe = EEscolaridade.EnsinoSuperior;
        //            funcionarios.Add(new Contratado(nome, cpf, escolaridadeEscolhe));
        //            break;
        //        case 3:
        //            escolaridadeEscolhe = EEscolaridade.Mestrado;
        //            funcionarios.Add(new Contratado(nome, cpf, escolaridadeEscolhe));
        //            break;
        //        case 4:
        //            escolaridadeEscolhe = EEscolaridade.SegudundoGrau;
        //            funcionarios.Add(new Contratado(nome, cpf, escolaridadeEscolhe));
        //            break;
        //        default:
        //            HelpersAlias.PostString(erro);
        //            break;
        //    }
        //    HelpersAlias.PostString("Professor Registrado com Sucesso!");
        //}

        private static void ConsultarFuncionario()
        {
            var cpf = HelpersAlias.GetInputString("Informe o CPF:", erro);
            var funcionarioConsultado = funcionarios.FirstOrDefault(professor => professor.Cpf == cpf);
            Console.Clear();

            if (funcionarioConsultado == null)
            {
                HelpersAlias.PostString(erro);
            }
            else
            {
                var horistaProfessor = funcionarioConsultado as Horista;

                if (horistaProfessor == null)
                {
                    funcionarioConsultado = funcionarioConsultado as Contratado;
                }
                ExibeDados(funcionarioConsultado);
            }
        }

        private static void ExcluirFuncionario()
        {
            var nome = HelpersAlias.GetInputString(informeNome, erro);
            var funcionarioConsultado = funcionarios.FirstOrDefault(aluno => aluno.Nome == nome);
            Console.Clear();

            if (funcionarioConsultado == null)
            {
                HelpersAlias.PostString(erro);
            }
            else
            {
                ExibeDados(funcionarioConsultado);
                funcionarios.Remove(funcionarioConsultado);
                HelpersAlias.PostString(removidoSucesso);
            }
        }

        //private static void AlterarFuncionario()
        //{
        //    var nome = HelpersAlias.GetInputString("Digite o nome do professor:", "Nome invalido");
        //    var funcionarioConsultado = funcionarios.FirstOrDefault(aluno => aluno.Nome == nome);

        //    if (funcionarioConsultado == null)
        //    {
        //        HelpersAlias.PostString(erro);
        //    }
        //    else
        //    {
        //        var horistaProfessor = funcionarioConsultado as Horista;
        //        funcionarios.Remove(funcionarioConsultado);


        //        if (horistaProfessor == null)
        //        {
        //            ProfessorContratado(nome, GetCpf());
        //        }
        //        else
        //        {
        //            ProfessorHorista(nome, GetCpf());
        //        }
        //        HelpersAlias.PostString("Alterado com Sucesso!");
        //    }
        //}


        private static string GetNome()
        {
            
            return HelpersAlias.GetInputString("Insira o Nome do professor", erro);
        }

        private static void ListaFuncionarios()
        {
            Console.Clear();
            if (funcionarios.Count == 0)
            {
                HelpersAlias.PostString("Lista Vazia!");
                return;
            }
            else
            {
                foreach (Funcionario professor in funcionarios)
                {
                    var horistaProfessor = professor as Horista;

                    if (horistaProfessor == null)
                    {
                        var contratadoProfessor = professor as Contratado;
                    }
                    ExibeDados(professor, false, false);
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }

        private static string GetCpf()
        {
            return HelpersAlias.GetInputString("Insira o Cpf do professor", erro);
        }
        private static string VerificaExisteCpf()
        {
            var cpf = "";
            while (true)
            {
                cpf = GetCpf();
                Funcionario cpfConsulta = funcionarios.FirstOrDefault(professor => professor.Cpf == cpf);
                if(cpfConsulta != null)
                {
                    HelpersAlias.PostString("Erro - Cpf existente!");
                    return VerificaExisteCpf();
                }
                    return cpf;
            }
        }

        //private static void TipoFuncionario()
        //{
        //    var opcao = HelpersAlias.GetInputSwicth("Selecionar o tipo de professor \n" +
        //        "01 - Contratado \n" +
        //        "02 - Horista", erro, 1, 2);
        //    Console.WriteLine();

        //    string cpf = VerificaExisteCpf();


        //    switch (opcao)
        //    {
        //        case 1:
        //            ProfessorContratado(GetNome(),cpf);
        //            break;
        //        case 2:
        //            ProfessorHorista(GetNome(), cpf);
        //            break;
        //    }
        //}

        private static void ExibeDados(Funcionario funcionarioConsultado, bool ReadKey = true, bool limparTela = true)
        {
            var salarioFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"),
                "{0:C}", funcionarioConsultado.SalarioFuncionario());
            HelpersAlias.PostString($"Dados funcionário:\n" +
                        $"Nome: {funcionarioConsultado.Nome}\n" +
                        $"Cpf: {funcionarioConsultado.Cpf}\n" +
                        $"Salario: {salarioFormatado}", ReadKey, limparTela);
        }
    }
}