using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Dominio.Animais;

namespace Exercicio01.Repositorio
{
    public class AnimalRepositorio
    {
        private List<Animal> _animais = new List<Animal>();

        public List<Animal> BuscarTodos()
        {
            return _animais;
        }
    }
}
