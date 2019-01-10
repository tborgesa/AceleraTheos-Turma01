using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Dominio.Funcionario;

namespace SistemaEscola.Repositorio
{
    public class SistemaEscolaRepositorio
    {
        private List<Funcionario> _funcionarios = new List<Funcionario>();

        public void Inserir(Funcionario funcionario)
        {
            funcionario.GerarId();
            _funcionarios.Add(funcionario);
        }

        public Funcionario BuscarPorId(Guid id)
        {
            return _funcionarios.FirstOrDefault(f => f.Id == id);
        }

        public List<Funcionario> BuscarTodos()
        {
            return _funcionarios;
        }

        public void Atualizar(Funcionario Funcionario)
        {
            var FuncionarioLista = _funcionarios.FirstOrDefault(f => f.Id == Funcionario.Id);
            FuncionarioLista = Funcionario;
        }

        public void Excluir(Guid id)
        {
            _funcionarios = _funcionarios.Where(f => f.Id != id).ToList();
        }
    }
}
