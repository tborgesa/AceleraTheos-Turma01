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
        public static List<Funcionario> professores = new List<Funcionario>();
        public static string erro = "Valor Invalido!";
        public static string texto = "Digite uma opcao";
        public static string informeNome = "Informe o nome do professor:";

        static void Main(string[] args)
        {
            var opcao = 0;
            //A variavel pode ser abastar
            Funcionario professor = new Contratado("Nome",EEscolaridade.SegudundoGrau);
            //Console.WriteLine(professor);

            Funcionario professorHorista = new Horaista("NOME", 1);
            //Console.WriteLine(professorHorista);

            Console.WriteLine(texto);

            switch (2)
            {
                case 1:
                    professores.Add(new Contratado("Nome",EEscolaridade.Doutorado));
                    break;
                case 2:
                    var queryProfessor = from Funcionario in professores
                                         where professor.Nome == "NOME DESESJADO"
                                         select professor.Nome;
                    Console.WriteLine(queryProfessor);
                        break;
                case 3:
                    //altera
                    break;
                case 4:
                    //exclui
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }



        //private static Contratado ContratadoProfessor(EEscolaridade escolaridade)
        //{
        //    Console.WriteLine(informeNome);
        //    var nome = Console.ReadLine();
        //    Contratado professor = new Contratado(nome, escolaridade);
        //    return professor;
        //}
    }
}
