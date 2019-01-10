using SistemaEscola.Dominio.Escolaridade;
using SistemaEscola.Dominio.Escolaridade.Enumerador;
using EscolaridadeAlias = SistemaEscola.Dominio.Escolaridade.Escolaridade;
using System;

namespace SistemaEscola.Dominio.Funcionario
{
    public class Funcionario
    {
        public string erro { get; private set; }

        public Funcionario(string nome, EEscolaridade Escolaridade)
        {
            Nome = nome;
            InstanciarEscolaridade(Escolaridade);
        }

        private void InstanciarEscolaridade(EEscolaridade Escolaridade)
        {
            if (!Enum.IsDefined(typeof(EEscolaridade), Escolaridade))
            {
                erro = "Valor Invalido!";
                return;
            }


            switch (Escolaridade)
            {
                case EEscolaridade.SegudundoGrau:
                    Escolaridade = new SegundoGrau();
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

        public string Nome { get; }
        public EscolaridadeAlias Escolaridade { get; private set; }

    }
}
