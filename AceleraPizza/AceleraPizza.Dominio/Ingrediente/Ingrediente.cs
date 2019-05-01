using System;

namespace AceleraPizza.Dominio.Ingrediente
{
    public class Ingrediente : Entidade
    {
        public Ingrediente() { }

        public Ingrediente(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;

            Validar();
        }

        private void Validar()
        {
            if (string.IsNullOrWhiteSpace(Descricao))
                AdicionarErro("Preencha o nome do Ingrediente.");

            if (double.IsNegativeInfinity(Valor))
                    AdicionarErro("Preencha o valor positivo.");

        }

        public override Guid Id { get; set; }
        public override DateTime DataInsercao { get; set; }
        public override DateTime? DataAlteracao { get; set; }

        public string Descricao { get; set; }
        public double Valor { get; set; }

        public void AlteraIngrediente(IngredienteAtualizarViewModel ingredienteAtualizarViewModel)
        {
            Validar();
            Descricao = ingredienteAtualizarViewModel.Descricao;
            Valor = ingredienteAtualizarViewModel.Valor;
        }
    }
}
