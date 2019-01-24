using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Dominio.Pessoas;

namespace PetShop.Dominio.Animais
{
    public class AnimalDto
    {
        public Guid Id { get; set; }
        public string Nome { get; }
        public Cliente Dono { get; set; }
        public Enum Especie { get; }
        public string erro { get;  set; }
        public double ValorLimpeza { get; set; }
        public string Raca { get; }
        public double Peso { get;  set; }
        public double Altura { get;  set; }
        public double Largura { get;  set; }
        public double Comprimento { get;  set; }
    }
}
