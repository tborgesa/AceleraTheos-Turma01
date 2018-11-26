using System;
using SistemaEscola.Dominio.Escolaridade.Enumerador;

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
        static void Main(string[] args)
        {
            int opcao = 1;

        }

        private void InstanciarEscolaridade(EEscolaridade Escolaridade)
        {
            if (!Enum.IsDefined(typeof(EEscolaridade), Escolaridade))
            {
                Console.WriteLine("Valor Invalido!");
            }


            switch (opcao)
            {
                case EEscolaridade.SegudundoGrau:
                    Escolaridade = new EEscolaridade();
                    break;
                case EEscolaridade.EnsinoSuperior:
                    Escolaridade = new EnsinoSuperior();
                    break;
                case EEscolaridade.Mestrado:
                    Escolaridade = new Mestrado();
                    break;
                case EEscolaridade.Doutorado:
                    Escolaridade = new Doutorado();
                    break;
                default:
                    break;
            }
        }
    }
}
