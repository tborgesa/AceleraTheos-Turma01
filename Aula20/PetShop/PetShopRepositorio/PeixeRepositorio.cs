using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Dominio.Animal.Peixe;

namespace PetShopRepositorio
{
    public class PeixeRepositorio
    {
        private List<Peixe> _peixes = new List<Peixe>();

        public void Inseir(Peixe peixe)
        {
            peixe.GerarId();
            _peixes.Add(peixe);
        }

        public Peixe BuscarPorId(Guid Id)
        {
            return _peixes.FirstOrDefault(f => f.Id == Id);
        }

        public List<Peixe> BuscarTodos()
        {
            return _peixes;
        }

        public void Atualizar(Peixe peixe)
        {
            var PeixeLista = _peixes.FirstOrDefault(f => f.Id == peixe.Id);
            PeixeLista = peixe;
        }

        public void Excluir(Guid id)
        {
            _peixes = _peixes.Where(f => f.Id != id).ToList();
        }
    }
}

