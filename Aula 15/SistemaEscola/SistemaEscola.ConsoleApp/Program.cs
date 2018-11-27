using System;
using HelpersAlias = SistemaEscola.Comum.Helpers.InputHelper;
using SistemaEscola.Dominio.Escolaridade.Enumerador;
using SistemaEscola.Dominio.Funcionario;
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
        public static string erro = "Valor Invalido!";
        public static string texto = "Digite uma opcao";

        static void Main(string[] args)
        {
            //A variavel pode ser abastar
            Funcionario professor = new Contratado("Nome",EEscolaridade.SegudundoGrau);
            Console.WriteLine(professor);

            Funcionario professorHorista = new Horaista("NOME", 1.5);
            Console.WriteLine(professorHorista);

            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
