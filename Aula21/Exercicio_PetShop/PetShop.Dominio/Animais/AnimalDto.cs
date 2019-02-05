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
        public string Nome { get; set; }
        public Cliente Cliente { get; set; }
        public string erro { get; set; }
        public double ValorLimpeza { get; set; }
        public string Raca { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }

    }

    public class AnimalDtoReturn
    {
        public AnimalDto Animal { get; }
        public List<string> Erros { get; }

        public AnimalDtoReturn()
        {

        }

        public AnimalDtoReturn (AnimalDto animal)
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
