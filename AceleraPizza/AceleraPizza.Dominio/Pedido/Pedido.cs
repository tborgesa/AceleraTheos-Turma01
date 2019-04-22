using System;
using System.Collections.Generic;
using AceleraPizza.Dominio.Borda.Enumerador;
using AceleraPizza.Dominio.PedidoIngrediente;
using AceleraPizza.Dominio.Tamanho.Enumerador;

namespace AceleraPizza.Dominio.Pedido
{
    public class Pedido : Entidade
    {
        public Pedido()
        {

        }

        public Pedido(ETamanho tamanho, EBorda borda, List<_PedidoIngrediente> listaIngredientes, Guid idCliente)
        {
            Tamanho = tamanho;
            Borda = borda;
            IdCliente = idCliente;

            ValidaTamanho(tamanho);
            ValidaBorda(borda);

            SetListaIngredientes(listaIngredientes);
            SetValor();
        }

        public override Guid Id { get; set; }

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

        private void ValidaTamanho(ETamanho tamanho)
        {
            if (!Enum.IsDefined(typeof(ETamanho), tamanho))
                AdicionarErro("Tamanho Invalida");
        }

        private void ValidaBorda(EBorda borda)
        {
            if (!Enum.IsDefined(typeof(EBorda), borda))
                AdicionarErro("Borda Invalida");
        }

        public void GetValorTamanho()
        {

        }

        public void SetValor()
        {
            Total = 0;
        }

        public void AlterarTamanho(ETamanho etamanho)
        {
            Tamanho = etamanho;
        }

        public void AlterarBorda(EBorda eborda)
        {
            Borda = eborda;
        }

        public void SetListaIngredientes(List<_PedidoIngrediente> ingredientes)
        {
            ListaIngredientes = new List<_PedidoIngrediente>();
            foreach (var item in ingredientes)
            {
                item.Id = Guid.NewGuid();
                ListaIngredientes.Add(item);
            }
        }

        public void GetValorBorda() { }
        public ETamanho Tamanho { get; set; }
        public EBorda Borda { get; set; }
        public List<_PedidoIngrediente> ListaIngredientes { get; set; }
        public Guid IdCliente { get; set; }
        public double Total { get; set; }
    }
}
