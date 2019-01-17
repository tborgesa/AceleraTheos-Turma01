using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Dominio.Animal.Cachorro;

namespace PetShopRepositorio
{
    public class CachorroRepositorio
    {
        private List<Cachorro> _cachorros = new List<Cachorro>();

        public void Inseir(Cachorro cachorro)
        {
            cachorro.GerarId();
            _cachorros.Add(cachorro);
        }

        public Cachorro BuscarPorId (Guid Id)
        {
            return _cachorros.FirstOrDefault(f => f.Id == Id);
        }

        public List <Cachorro> BuscarTodos()
        {
            return _cachorros;
        }

        public void Atualizar(Cachorro cachorro)
        {
            var CachorroLista = _cachorros.FirstOrDefault(f => f.Id == cachorro.Id);
            CachorroLista = cachorro;
        }

        public void Excluir (Guid id)
        {
            _cachorros = _cachorros.Where(f => f.Id != id).ToList();
        }
    }
}
