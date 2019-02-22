using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Dominio.Animal.Gato
{
    public class GatoInserirViewModel
    {
        public string NomeAnimal { get; set; } = "";
        public string NomeDono { get; set; } = "";
        public string CpfDono { get; set; } = "";
        public decimal Peso { get; set; }
    }
}
