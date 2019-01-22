using System;
using SistemaEscola.Dominio.Escolaridade.Enumerador;
using EscolaridadeALias = SistemaEscola.Dominio.Escolaridade.Escolaridade;
using EscolaridadeALiasAux = SistemaEscola.Dominio.Escolaridade;

namespace SistemaEscola.Dominio.Funcionario
{
    public class Contratado : Funcionario
    {
        public EscolaridadeALias Escolaridade { get; private set; }

        public Contratado(DateTime dataNascimento, string nome, string cpf, string endereco,  EEscolaridade escolaridade) :
            base (nome, cpf, dataNascimento, endereco)
        {
            InstanciarEscolaridade(escolaridade);
            ValidaEscolaridade(escolaridade);
        }

        private void ValidaEscolaridade(EEscolaridade escolaridade)
        {
            if (!Enum.IsDefined(typeof(EEscolaridade),escolaridade))
                AdicionarErro("Escolaridade Invalida");
        }

        public EEscolaridade GetEEscolaridade() {
            var tipo = Escolaridade as EscolaridadeALiasAux.SegundoGrau;
            if (tipo != null) return EEscolaridade.SegudundoGrau;

            var tipo1 = Escolaridade as EscolaridadeALiasAux.EnsinoSuperior;
            if (tipo1 != null) return EEscolaridade.EnsinoSuperior;

            var tipo2 = Escolaridade as EscolaridadeALiasAux.Mestrado;
            if (tipo2 != null) return EEscolaridade.Mestrado;

            return EEscolaridade.Doutorado;
        }

        public void InstanciarEscolaridade(EEscolaridade eEscolaridade)
        {
            if (!EEscolaridade.IsDefined(typeof(EEscolaridade), eEscolaridade))
            {
                System.Console.WriteLine("Escolaridade Incorreta");
                return;
            }

            switch (eEscolaridade)
            {
                case EEscolaridade.SegudundoGrau:
                    Escolaridade = new EscolaridadeALiasAux.SegundoGrau();
                    break;
                case EEscolaridade.EnsinoSuperior:
                    Escolaridade = new EscolaridadeALiasAux.EnsinoSuperior();
                    break;
                case EEscolaridade.Mestrado:
                    Escolaridade = new EscolaridadeALiasAux.Mestrado();
                    break;
                case EEscolaridade.Doutorado:
                    Escolaridade = new EscolaridadeALiasAux.Doutorado();
                    break;
                default:
                    break;
            }
        }

        public override void Gravar() { }

        public void AlterarEscolaridade(EEscolaridade eEscolaridade)
        {
            InstanciarEscolaridade(eEscolaridade);
            Console.WriteLine("Alterar Escolaridade do Professor");
        }

        public override decimal SalarioFuncionario()
        {
            return Escolaridade.Salario;
        }
    }
}
