using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Dominio.Animais
{
    public class Gato : AnimalTerrestre
    {
        public Gato(string nome, double peso) : base(nome, peso)
        {

        }

        public override decimal CalculaPreco()
        {
            decimal preco = (decimal)(Peso * 1.6);
            return preco;
        }


        
    }
}
