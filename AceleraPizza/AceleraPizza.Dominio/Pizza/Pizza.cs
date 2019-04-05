using AceleraPizza.Dominio.Ingredientes;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Pizza
{
    public class Pizza : Entidade
    {
        public string Tamanho { get; set; }
        public List<IngredientesItens> ListaIngredientes { get; set; }
        public string Bordas { get; set; }
    }
}
