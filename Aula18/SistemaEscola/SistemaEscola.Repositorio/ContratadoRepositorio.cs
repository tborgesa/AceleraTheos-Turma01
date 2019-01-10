using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Dominio.Funcionario;

namespace SistemaEscola.Repositorio
{
    public class ContratadoRepositorio
    {
        private List<Contratado> _contratados = new List<Contratado>();

        public void Inserir(Contratado contratado)
        {
            contratado.GerarId();
            _contratados.Add(contratado);
        }

        public Contratado BuscarPorId(Guid id)
        {
            return _contratados.FirstOrDefault(f => f.Id == id);
        }

        public List<Contratado> BuscarTodos()
        {
            return _contratados;
        }

        public void Atualizar(Contratado contratado)
        {
            var ContratadoLista = _contratados.FirstOrDefault(f => f.Id == contratado.Id);
            ContratadoLista = contratado;
        }

        public void Excluir(Guid id)
        {
            _contratados = _contratados.Where(f => f.Id != id).ToList();
        }
    }
}
