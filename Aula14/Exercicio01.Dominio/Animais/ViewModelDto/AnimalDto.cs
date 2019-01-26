using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Dominio.Enumerador;

namespace Exercicio01.Dominio.Animais
{
    public class AnimalDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }
        public double Altura { get; set; }
        public Enum TipoAnimal { get; set; }
    }

    public class AnimalDtoReturn
    {
        public AnimalDto Animal { get; }
        public List<string> Erros { get; }

        public AnimalDtoReturn(AnimalDto animal)
        {
            Animal = animal;
            Erros = new List<string>();
        }

        public AnimalDtoReturn(List<string> erros)
        {
            Erros = erros;
        }
    }

}
