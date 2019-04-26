using Newtonsoft.Json;
using System;

namespace AceleraPizza.Dominio.PedidoIngrediente
{
    public class PedidoIngredienteInserirViewModel
    {
        [JsonIgnore] 
        public Guid Id { get; set; }
        public Guid IdIngrediente { get; set; }
        public Int16 Quantidade { get; set; }
    }
}
