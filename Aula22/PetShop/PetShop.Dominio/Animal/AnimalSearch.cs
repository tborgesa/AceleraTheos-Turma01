using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Dominio.Animal
{
    public class AnimalSearch
    {
        public Guid Id { get; set; }
        public string NomeAnimal { get; set; }
        public string NomeDono { get; set; }
        public string CpfDono { get; set; }
    }
}
