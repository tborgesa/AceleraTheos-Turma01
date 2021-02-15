using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Dominio.Pessoas;
using PetShop.Dominio.Animais.Enumerador;

namespace PetShop.Dominio.Animais
{
    public class AnimalinserirViewModel
    {
        public string Nome { get; } = "";
        public Guid DonoId { get; set; };
        public EnumEspecie Especie { get; set; } = EnumEspecie.Cachorro;
        public double ValorLimpeza { get; set; } = 0.00;
        public string Raca { get; } = "";
        public double Peso { get; set; } = 0.00;
        public double Altura { get; set; } = 0.00;
        public double Largura { get; set; } = 0.00;
        public double Comprimento { get; set; } = 0.00;
    }
}
