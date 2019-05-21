using Newtonsoft.Json;
using System;

namespace AceleraPizza.Dominio.PedidoIngrediente
{
    public class PedidoIngredienteViewModel
    {
        public PedidoIngredienteViewModel(){}

        public PedidoIngredienteViewModel(Guid idIngrediente, Int16 quantidade)
        {
            IdIngrediente = idIngrediente;
            Quantidade = quantidade;
        }

        [JsonIgnore]
        public Guid Id { get; set; }
        public Guid IdIngrediente { get; set; }
        public Int16 Quantidade { get; set; }
        [JsonIgnore]
        public Guid IdPedido { get; set; }
    }
}
