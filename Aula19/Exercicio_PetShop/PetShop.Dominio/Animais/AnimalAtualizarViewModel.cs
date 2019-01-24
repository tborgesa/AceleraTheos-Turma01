using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Dominio.Animais
{
    public class AnimalAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; } = "";
        public double Peso { get; set; } = 0.00;
        public double Altura { get; set; } = 0.00;
        public double Largura { get; set; } = 0.00;
        public double Comprimento { get; set; } = 0.00;
    }
}
