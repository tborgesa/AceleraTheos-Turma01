using System;
using System.Collections.Generic;
using AceleraPizza.Dominio.Borda.Enumerador;
using PedidoIngredienteAlias = AceleraPizza.Dominio.PedidoIngrediente.PedidoIngrediente;
using AceleraPizza.Dominio.Tamanho.Enumerador;

namespace AceleraPizza.Dominio.Pedido
{
    public class Pedido : Entidade
    {
        public Pedido()
        {

        }

        public Pedido(ETamanho tamanho, EBorda borda, List<PedidoIngredienteAlias> listaIngredientes, Guid idCliente)
        {
            Tamanho = tamanho;
            Borda = borda;
            IdCliente = idCliente;

            Validar();
            SetListaIngredientes(listaIngredientes);
            SetValor();
        }

        private void Validar()
        {
            if (!Enum.IsDefined(typeof(EBorda), Borda))
                AdicionarErro("Borda Invalida");
            if (!Enum.IsDefined(typeof(ETamanho), Tamanho))
                AdicionarErro("Tamanho Invalida");
            //TODO: AdicionarErro("Quantidade Invalida");
        }

        public void DescontoPorIdade(DateTime birthdate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthdate.Year;
            if (birthdate > today.AddYears(-age)) age--;
            if (age > 60) {
                Total = Total * 0.95;
            }
        }

        public double GetValorTamanho(ETamanho tamanho)
        {
            switch (tamanho)
            {
                case ETamanho.Pequena:
                    return 10;
                case ETamanho.Media:
                    return 15;
                default:
                    return 20;
            }
        }



        public void SetValor()
        {
            Total = 0;
            Total += GetValorTamanho(Tamanho);
            Total += GetValorBorda(Borda);
        }

        private double GetValorBorda(EBorda borda)
        {
            switch (borda)
            {
                case EBorda.SemRecheio:
                    return 0;
                case EBorda.Catupiry:
                    return 5;
                default:
                    return 4.5;
            }
        }

        public void AlterarTamanho(ETamanho etamanho)
        {
            Tamanho = etamanho;
        }

        public void AlterarBorda(EBorda eborda)
        {
            Borda = eborda;
        }

        public void SetListaIngredientes(List<PedidoIngredienteAlias> ingredientes)
        {
            ListaIngredientes = new List<PedidoIngredienteAlias>();
            foreach (var item in ingredientes)
            {
                item.Id = Guid.NewGuid();
                ListaIngredientes.Add(item);
            }
        }

        public List<PedidoIngredienteAlias> GetListaPedidoIngrediente(Guid id, List<PedidoIngredienteAlias> lista)
        {
            ListaIngredientes = new List<PedidoIngredienteAlias>();
            foreach (var item in lista)
            {
                if (item.IdPedido == id)
                {
                    ListaIngredientes.Add(item);
                }
            }

            return ListaIngredientes;
        }

        public override Guid Id { get; set; }
        public ETamanho Tamanho { get; set; }
        public EBorda Borda { get; set; }
        public List<PedidoIngredienteAlias> ListaIngredientes { get; set; }
        public Guid IdCliente { get; set; }
        public double Total { get; set; }

        public void AlterarListaIngrediente(List<PedidoIngredienteAlias> list)
        {
            ListaIngredientes = list;
        }
    }
}
