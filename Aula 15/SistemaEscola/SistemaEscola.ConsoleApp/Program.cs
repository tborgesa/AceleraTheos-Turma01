using System;
using SistemaEscola.Dominio.Escolaridade.Enumerador;
using HelpersAlias = SistemaEscola.Comum.Helpers.InputHelper;
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
            HoraistaVoid();
            Console.ReadKey();
        }

        private static void HoraistaVoid()
        {
            var entrada = HelpersAlias.GetInputDouble("Digite as horas do funcionario",erro);
            Console.WriteLine($"Professor receber :{HoraMinuto(entrada)}");
        }

        private static double HoraMinuto(double ent)
        {
            if (ent > 1)
            {
                var aux = (int)ent;
                ent = ent - aux;
                return (aux * 60) + (ent * 60);
            }
            return ent * 60;
        }
    }
}
