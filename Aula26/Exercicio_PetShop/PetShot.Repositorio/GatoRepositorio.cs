using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Dominio.Animais;

namespace PetShot.Repositorio
{
    public class GatoRepositorio
    {

        private List<Gato> _gatos = new List<Gato>();

        public void Inserir (Gato gato)
        {
            gato.GerarId();
            _gatos.Add(gato);
        }

        public Gato BuscarPorId(Guid id)
        {
            return _gatos.FirstOrDefault(g => g.Id == id);
        }

        public List<Gato> BuscarTodos()
        {
            return _gatos;
        }

        public void Atualizar (Gato gato)
        {
            var gatoLista = _gatos.FirstOrDefault(g => g.Id == gato.Id);
            gatoLista = gato;
        }

        public void Excluir(Guid id)
        {
            _gatos = _gatos.Where(g => g.Id != id).ToList();
        }

    }
}
