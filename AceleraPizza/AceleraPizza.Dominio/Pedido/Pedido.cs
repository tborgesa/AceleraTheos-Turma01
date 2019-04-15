using AceleraPizza.Comum.Helpers;
using System;

namespace AceleraPizza.Dominio.Pedido
{
    public class Pedido : Entidade
    {
        public Pedido() { }


        private void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                AdicionarErro("Preencha o nome.");

            if (string.IsNullOrWhiteSpace(Endereco))
                AdicionarErro("Preencha o endereço.");

            if (!(Telefone.Length >= 8 & Telefone.Length <= 10))
                AdicionarErro("Telefone inválido.");

            if (!CpfHelper.CpfValido(Cpf))
                AdicionarErro("CPF inválido.");

            if (DataNascimento < new DateTime(1900, 01, 01).Date)
                AdicionarErro("Data Inválida.");
        }


        public ETamanho Tamanho { get; set; }
        public Ingrediente ListaIngredientes { get; set; }
        public EBorda Borda { get; set; }
        public Cliente Cliente { get; set; }
        public double Total { get; set; }

        public void GetValorTamhno();
        public void GetValorBorda();
        public void SetValor();

    }
}
