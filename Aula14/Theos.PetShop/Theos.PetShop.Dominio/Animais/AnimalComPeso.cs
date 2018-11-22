using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.PetShop.Dominio.Animais
{
    public abstract class AnimalComPeso : Animal
    {
        public double Peso { get; private set; }
        public AnimalComPeso(string nome, double peso) : base(nome)
        {
            Peso = peso;
        }
        public override abstract double CalculaLimpeza();
        
    }

}
