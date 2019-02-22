using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Dominio.Animal.Gato
{
    public class GatoAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public decimal Peso { get; set; }
    }
}
