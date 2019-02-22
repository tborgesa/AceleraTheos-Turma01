using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Dominio.Animal.Peixe
{
    public class PeixeAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }
        public decimal Comprimento { get; set; }
    }
}
