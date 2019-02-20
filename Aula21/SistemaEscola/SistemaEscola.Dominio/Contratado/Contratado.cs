using System;
using SistemaEscola.Dominio.Escolaridade.Enumerador;
using EscolaridadeALias = SistemaEscola.Dominio.Escolaridade.Escolaridade;
using EscolaridadeALiasAux = SistemaEscola.Dominio.Escolaridade;

namespace SistemaEscola.Dominio.Funcionario
{
    public class Contratado : Funcionario
    {

        public EscolaridadeALias Escolaridade { get; set; }
        public EEscolaridade EscolaridadeEnum { get; set; }

        public Contratado() { }

        public Contratado(DateTime dataNascimento, string nome, string cpf, string endereco,  EEscolaridade escolaridade) :
            base (nome, cpf, dataNascimento, endereco)
        {
            //Deve setar para corrigir
            ValidaEscolaridade(escolaridade);
            InstanciarEscolaridade(escolaridade);
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
            ValidaEscolaridade(eEscolaridade);
            InstanciarEscolaridade(eEscolaridade);
        }

        public override decimal SalarioFuncionario()
        {
            return Escolaridade.Salario;
        }
    }
}
