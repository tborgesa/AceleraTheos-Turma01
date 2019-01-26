using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Dominio.Animais
{
    public abstract class AnimalAquatico : Animal
    {
        protected AnimalAquatico(string nome, double largura, double comprimento, double altura): base (nome)
        {
            Largura = largura;
            Comprimento = comprimento;
            Altura = altura;
        }

        public double Largura { get; set; }
        public double Comprimento { get; set; }
        public double Altura { get; set; }

        //public abstract decimal CalculaPrecoAnimalAquatico(double largura, double comprimento, double altura);
        public abstract double RetornaVolume();
    }
}
