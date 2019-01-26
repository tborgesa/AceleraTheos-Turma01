using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Dominio.Animais;

namespace Exercicio01.Repositorio
{
    public class CachorroRepositorio
    {
        public static List<Cachorro> _cachorros = new List<Cachorro>();

        public void Inserir(Cachorro cachorro)
        {
            cachorro.GerarId();
            _cachorros.Add(cachorro);
        }

        public Cachorro BuscarPorId(Guid id)
        {
            return _cachorros.FirstOrDefault(c => c.Id == id);
        }

        public List<Cachorro> BuscarTodos()
        {
            return _cachorros;
        }

        public void Atualizar(Cachorro cachorro)
        {
            var cachorroLista = _cachorros.FirstOrDefault(c => c.Id == cachorro.Id);
            cachorroLista = cachorro;
        }

        public void Excluir(Guid id)
        {
            _cachorros = _cachorros.Where(c => c.Id != id).ToList();
        }
    }
}
