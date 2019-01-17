using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Dominio.Animal.Peixe
{
    public class PeixeInserirViewModel
    {
        public string NomeAnimal { get; set; } = "";
        public string NomeDono { get; set; } = "";
        public string CpfDono { get; set; } = "";
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }
        public decimal Comprimento { get; set; }
    }
}
