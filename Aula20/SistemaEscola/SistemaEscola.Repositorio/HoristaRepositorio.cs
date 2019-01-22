using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Dominio.Funcionario;

namespace SistemaEscola.Repositorio
{
    public class HoristaRepositorio
    {
        private List<Horista> _horistas = new List<Horista>();

        public void Inserir(Horista funcionario)
        {
            funcionario.GerarId();
            _horistas.Add(funcionario);
        }

        public Horista BuscarPorId(Guid id)
        {
            return _horistas.FirstOrDefault(f => f.Id == id);
        }

        public List<Horista> BuscarTodos()
        {
            return _horistas;
        }

        public void Atualizar(Horista Horista)
        {
            var HoristaLista = _horistas.FirstOrDefault(f => f.Id == Horista.Id);
            HoristaLista = Horista;
        }

        public void Excluir(Guid id)
        {
            _horistas = _horistas.Where(f => f.Id != id).ToList();
        }
    }
}
