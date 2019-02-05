using System;
using System.Collections.Generic;
using System.Linq;
using PetShop.Dominio.Animal.Gato;

namespace PetShopRepositorio
{
    public class GatoRepositorio
    {
        private List<Gato> _gatos = new List<Gato>();

        public void Inseir(Gato gato)
        {
            gato.GerarId();
            _gatos.Add(gato);
        }

        public Gato BuscarPorId(Guid Id)
        {
            return _gatos.FirstOrDefault(f => f.Id == Id);
        }

        public List<Gato> BuscarTodos()
        {
            return _gatos;
        }

        public void Atualizar(Gato gato)
        {
            var GatoLista = _gatos.FirstOrDefault(f => f.Id == gato.Id);
            GatoLista = gato;
        }

        public void Excluir(Guid id)
        {
            _gatos = _gatos.Where(f => f.Id != id).ToList();
        }
    }
}
