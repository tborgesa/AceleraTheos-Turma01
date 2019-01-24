using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Dominio.Animais;

namespace PetShot.Repositorio
{
    public class CachorroRepositorio
    {
        private List<Cachorro> _cachorros = new List<Cachorro>();

        public void Inserir(Cachorro cachorro)
        {
            cachorro.GerarId();
            _cachorros.Add(cachorro);
        }


    }
}
