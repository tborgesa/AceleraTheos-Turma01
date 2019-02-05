using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Dominio.Pessoas;
using PetShop.Dominio.Animais.Enumerador;

namespace PetShop.Dominio.Animais
{
    public class AnimalInserirViewModel
    {
        public string Nome { get; } = "Biju";
        public Guid DonoId { get; set; }
        public EnumEspecie Especie { get; set; } = EnumEspecie.Cachorro;
        public double ValorLimpeza { get; set; } = 0.00;
        public string Raca { get; } = "Rot";
        public double Peso { get; set; } = 65;
        public double Altura { get; set; } = 0.00;
        public double Largura { get; set; } = 0.00;
        public double Comprimento { get; set; } = 0.00;
    }
}
