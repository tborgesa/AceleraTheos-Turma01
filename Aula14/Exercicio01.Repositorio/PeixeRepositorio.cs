using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Dominio.Animais;

namespace Exercicio01.Repositorio
{
    class PeixeRepositorio
    {
        private List<Peixe> _peixes = new List<Peixe>();

        public void Inserir(Peixe peixe)
        {
            peixe.GerarId();
            _peixes.Add(peixe);
        }

        public Peixe BuscarPorId(Guid id)
        {
            return _peixes.FirstOrDefault(p => p.Id == id);
        }

        public List<Peixe> BuscarTodos()
        {
            return _peixes;
        }

        public void Atualizar(Peixe peixe)
        {
            var peixeLista = _peixes.FirstOrDefault(p => p.Id == peixe.Id);
            peixeLista = peixe;
        }

        public void Excluir(Guid id)
        {
            _peixes = _peixes.Where(p => p.Id != id).ToList();
        }
    }
}
