using AceleraPizza.Comum.Helpers;
using System;

namespace AceleraPizza.Dominio.Pedido
{
    public class Pedido : Entidade
    {
        public Pedido() { }

        //TODO: O total seria um valor zerado para depois ser preenchido?
        public override Guid Id { get; set; }

        public Pedido(int tamanho, int idPedidoIngrediente, int borda, int cliente, double total)
        {
            Tamanho = tamanho;
            IdPedidoIngrediente = idPedidoIngrediente;
            Borda = borda;
            Cliente = cliente;
            Total = total;

            GetValorTamanho();
            GetValorBorda();
            SetValor(total);
        }

        //private void Validar()
        //{
        //    if (string.IsNullOrWhiteSpace(Nome))
        //        AdicionarErro("Preencha o nome.");

        //    if (string.IsNullOrWhiteSpace(Endereco))
        //        AdicionarErro("Preencha o endereço.");

        //    if (!(Telefone.Length >= 8 & Telefone.Length <= 10))
        //        AdicionarErro("Telefone inválido.");

        //    if (!CpfHelper.CpfValido(Cpf))
        //        AdicionarErro("CPF inválido.");

        //    if (DataNascimento < new DateTime(1900, 01, 01).Date)
        //        AdicionarErro("Data Inválida.");
        //}

        public void GetValorTamanho() { }
        public void GetValorBorda() { }

        public void SetValor(double total) {

            Total = total;
        }

        public void AlterarTamanho(int tamanho)
        {
            Tamanho = tamanho;
        }

        public void AlterarIdPedidoIngrediente(int idPedidoIngrediente)
        {
            /*todo: Duvida seria o mais apropriado uma chave estrangeira 
            para a tabela alimentada com a quantidade do que necessita?*/
            IdPedidoIngrediente = idPedidoIngrediente;
        }

        public void AlterarBorda(int borda)
        {
            Borda = borda;
        }

        public int Tamanho { get; set; }
        public int IdPedidoIngrediente { get; set; }
        public int Borda { get; set; }
        public int Cliente { get; set; }
        public double Total { get; set; }
    }
}
