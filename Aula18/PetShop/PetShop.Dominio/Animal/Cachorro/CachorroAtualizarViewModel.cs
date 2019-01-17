using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Dominio.Animal.Cachorro
{
    public class CachorroAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public decimal Peso { get; set; }
    }
}
