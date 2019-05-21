using AceleraPizza.Dominio.Borda.Enumerador;
using AceleraPizza.Dominio.Tamanho.Enumerador;
using PedidoIngredienteAlias = AceleraPizza.Dominio.PedidoIngrediente.PedidoIngredienteViewModel;
using System;
using System.Collections.Generic;
using AceleraPizza.Dominio.Ingrediente;
using Newtonsoft.Json;

namespace AceleraPizza.Dominio.Pedido
{
    public class PedidoInserirViewModel
    {
        public ETamanho Tamanho { get; set; }
        public List<PedidoIngredienteAlias> ListaIngredientes { get; set; }
        public EBorda Borda { get; set; }
        public Guid IdCliente { get; set; }
        [JsonIgnore]
        public List<IngredienteViewModel> Ingredientes { get; set; }

        public List<PedidoIngredienteAlias> GetListaIngredientes(List<PedidoIngredienteAlias> listaIngredientes)
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
