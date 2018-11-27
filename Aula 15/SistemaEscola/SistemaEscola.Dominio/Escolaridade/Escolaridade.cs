using System;
using SistemaEscola.Dominio.Escolaridade.Enumerador;
using SistemaEscola.Dominio.Escolaridade;

namespace SistemaEscola.Dominio.Escolaridade
{
    public class Escolaridade
    {
        public string erro { get; private set; }

        public Escolaridade (string escolariadade, decimal salario)
        {
            //            InstanciarEscolaridade(eEscolaridade);
            escolaridade = escolariadade;
            Salario = salario;
        }


        private void InstanciarEscolaridade(EEscolaridade eEscolaridade)
        {
            if (!Enum.IsDefined(typeof(EEscolaridade), eEscolaridade))
            {
                erro = "Escolaridade Invalida!";
                return;
            }

 /*           switch (eEscolaridade)
            {
                case EEscolaridade.SegudundoGrau:
                    eEscolaridade = new Escolaridade (EEscolaridade.SegudundoGrau);
                    break;
                case EEscolaridade.EnsinoSuperior:
                    eEscolaridade = new Escolaridade(EEscolaridade.EnsinoSuperior);
                    break;
                case EEscolaridade.Mestrado:
                    eEscolaridade = new Escolaridade(EEscolaridade.Mestrado);
                    break;
                case EEscolaridade.Doutorado:
                    eEscolaridade = new Escolaridade(EEscolaridade.Doutorado);
                    break;
                default:
                    break;
            }*/
        }

        private readonly string escolaridade;

        public string GetEscolaridade()
        {
            return escolaridade;
        }

        public decimal Salario { get; }

        public virtual decimal GetSalario()
        {
            return Salario;
        }
    }
}
