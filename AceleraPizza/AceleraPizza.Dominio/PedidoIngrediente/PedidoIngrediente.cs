using Newtonsoft.Json;
using System;

namespace AceleraPizza.Dominio.PedidoIngrediente
{
    public class PedidoIngrediente : BaseEntidade
    {
        public Guid IdIngrediente { get; set; }
        public Int16 Quantidade { get; set; }

        [JsonIgnore]
        public override Guid Id { get; set; }
        [JsonIgnore]
        public Guid IdPedido { get; set; } 

        public PedidoIngrediente() { }
                
        public PedidoIngrediente(Guid idIngrediente, Int16 quantidade)
        {
            IdIngrediente = idIngrediente;
            Quantidade = quantidade;
        }
    }
}
