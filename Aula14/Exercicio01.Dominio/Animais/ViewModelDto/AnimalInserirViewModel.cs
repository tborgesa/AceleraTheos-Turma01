using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Dominio.Enumerador;

namespace Exercicio01.Dominio.Animais
{
    public class AnimalInserirViewModel
    {
        public string Nome { get; set; } = "";
        public double Peso { get; set; }
        public double Largura { get; set; } = 0.0;
        public double Comprimento { get; set; } = 0.0;
        public double Altura { get; set; } = 0.0;
        public EnumAnimal TipoAnimal { get; set; } = EnumAnimal.Cachorro;
    }
}
