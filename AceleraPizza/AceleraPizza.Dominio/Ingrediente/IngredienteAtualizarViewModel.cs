using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Dominio.Ingrediente
{
    public class IngredienteAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
