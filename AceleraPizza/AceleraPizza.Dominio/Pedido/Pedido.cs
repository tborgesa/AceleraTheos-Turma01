using System;
using System.Collections.Generic;
using AceleraPizza.Dominio.Borda.Enumerador;
using IngredienteAlias = AceleraPizza.Dominio.Ingrediente.IngredienteView;
using PedidoIngredienteAlias = AceleraPizza.Dominio.PedidoIngrediente.PedidoIngredienteView;
using AceleraPizza.Dominio.Tamanho.Enumerador;
using System.Linq;

namespace AceleraPizza.Dominio.Pedido
{
    public class Pedido : Entidade
    {
        public Pedido() { }

        public Pedido(ETamanho tamanho, EBorda borda, List<PedidoIngredienteAlias> listaIngredientes, Guid idCliente, List<IngredienteAlias> ingredientes)
        {
            Tamanho = tamanho;
            Borda = borda;
            IdCliente = idCliente;
            Ingredientes = ingredientes;

            SetListaIngredientes(listaIngredientes);
            Validar(ingredientes);
            SetValor();
        }

        public override Guid Id { get; set; }
        public ETamanho Tamanho { get; set; }
        public EBorda Borda { get; set; }
        public List<PedidoIngredienteAlias> ListaIngredientes { get; set; }
        public Guid IdCliente { get; set; }
        public double Total { get; set; }
        public List<IngredienteAlias> Ingredientes { get; set; }

        private void Validar(List<IngredienteAlias> ingredientes)
        {
            if (!Enum.IsDefined(typeof(EBorda), Borda))
                AdicionarErro("Borda Invalida");
            if (!Enum.IsDefined(typeof(ETamanho), Tamanho))
                AdicionarErro("Tamanho Invalida");
            foreach (var item in ListaIngredientes)
            {
                if (ingredientes.FirstOrDefault(i => i.Id == item.IdIngrediente) == null)
                    //todo adiaionar erro - OK
                    AdicionarErro("Ingrediente não existe!");

                if (item.Quantidade < 1)
                        AdicionarErro("Quantidade Invalida. Informe valor acima de 0");
            }
            //Validacao de IdIngrediente no Servico
        }

        public void AlterarPedido(PedidoAtualizarViewModel pedidoAtualizarViewModel, Cliente.Cliente cliente, double ValorTotalIngredientes)
        {
            Tamanho = pedidoAtualizarViewModel.Tamanho;
            Borda = pedidoAtualizarViewModel.Borda;
            ListaIngredientes = pedidoAtualizarViewModel.ListaIngredientes;
            Total += ValorTotalIngredientes;
            SetValor();
            DescontoPorIdade(cliente);
            SetarAlteracao();
        }

        //Desconto para Inserir no Servico
        public void DescontoPorIdade(Cliente.Cliente cliente)
        {
            DateTime dataNascimento = cliente.DataNascimento;
            var today = DateTime.Today;
            var idade = today.Year - (dataNascimento).Year;
            if (dataNascimento > today.AddYears(-idade)) idade--;
            if (idade > 60)
            {
                Total = Total * 0.95;
            }
        }

        //Instanciando a lista de PedidoIngrediente
        public void SetListaIngredientes(List<PedidoIngredienteAlias> ingredientes)
        {
            ListaIngredientes = new List<PedidoIngredienteAlias>();
            foreach (var item in ingredientes)
            {
                item.Id = Guid.NewGuid();
                ListaIngredientes.Add(item);
            }
        }

        //TODOD: Metodo apos correcao do Service PedidoIngrediente alterar no service de BuscarTodos para BuscarPorID
        //TDODO: Alterar o metodo GetListaPedi... para tirar a comparacao antes usada para insercao correta ao instanciar a lista de ingredientes.
        public List<PedidoIngredienteAlias> GetListaPedidoIngrediente(List<PedidoIngredienteAlias> lista)
        {
            ListaIngredientes = new List<PedidoIngredienteAlias>();
            foreach (var item in lista)
            {
                if (item.IdPedido == Id)
                {
                    ListaIngredientes.Add(item);
                }
            }

            return ListaIngredientes;
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

        public void SetValor()
        {
            Total = 0;
            Total += GetValorTamanho(Tamanho);
            Total += GetValorBorda(Borda);
        }

    }
}
