using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Dominio.Animais
{
    public class Peixe : AnimalAquatico
    {
        public Peixe(string nome, double largura, double comprimento, double altura) : base(nome,largura,comprimento,altura)
        {

        }

        public override decimal CalculaPreco()
        {
            decimal preco = (decimal)(Largura * Comprimento * Altura);
            return preco;
        }
    }
}
