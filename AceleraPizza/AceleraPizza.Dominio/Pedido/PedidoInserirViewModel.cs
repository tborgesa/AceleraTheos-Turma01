using AceleraPizza.Dominio.Borda.Enumerador;
using AceleraPizza.Dominio.PedidoIngrediente;
using AceleraPizza.Dominio.Tamanho.Enumerador;
using PedidoIngredienteAlias = AceleraPizza.Dominio.PedidoIngrediente.PedidoIngrediente;
using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoInserirViewModel
    {
    public ETamanho Tamanho { get; set; }
    public List<PedidoIngredienteInserirViewModel> ListaIngredientes { get; set; }
    public EBorda Borda { get; set; }
    public Guid IdCliente { get; set; }

        public List<PedidoIngredienteAlias> GetListaIngredientes(List<PedidoIngredienteInserirViewModel> listaIngredientes)
        {
            var lista = new List<PedidoIngredienteAlias>();
            foreach (var item in listaIngredientes)
            {
                lista.Add(new PedidoIngredienteAlias(item.IdIngrediente, item.Quantidade));
            }
            return lista;
        }
    }
}
