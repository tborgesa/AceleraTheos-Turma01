using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Dominio.Animais
{
    public class Cachorro : AnimalTerrestre
    {
        public Cachorro(string nome, double peso) : base(nome,peso)
        {

        }

        public override decimal CalculaPreco()
        {
            decimal preco = (decimal)(Peso * 2);
            return preco;
        }
    }
}
