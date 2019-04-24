using AceleraPizza.Dominio.Borda.Enumerador;
using PedidoIngredienteAlias = AceleraPizza.Dominio.PedidoIngrediente;
using AceleraPizza.Dominio.Tamanho.Enumerador;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoDto
    {
        public Guid Id { get; set; }
        public ETamanho Tamanho { get; set; }
        public List<PedidoIngrediente.PedidoIngrediente> ListaIngredientes { get; set; }
        public EBorda Borda { get; set; }
        public Guid IdCliente { get; set; }
        public double Total { get; set; }
    }

    public class PedidoDtoReturn
    {
        public PedidoDtoReturn(PedidoDto pedido)
        {
            Pedido = pedido;
            Erros = new List<string>();
        }

        private List<PedidoIngrediente.PedidoIngrediente> GetPedidoIngrediente(Guid id)
        {
            var lista = new List<PedidoIngrediente.PedidoIngrediente>();
            foreach (var item in lista)
            {
                lista.Add(new PedidoIngredienteAlias.PedidoIngrediente { Id = item.Id, Quantidade = item.Quantidade, IdIngrediente = item.IdIngrediente });
            }
            return lista;
        }

        public PedidoDtoReturn(List<string> erros)
        {
            Erros = erros;
        }

        public PedidoDto Pedido { get; }
        public List<string> Erros { get; }
    }
}