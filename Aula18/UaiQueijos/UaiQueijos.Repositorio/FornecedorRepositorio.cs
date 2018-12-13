using System;
using System.Collections.Generic;
using System.Linq;
using UaiQueijos.Dominio.Fornecedor;

namespace UaiQueijos.Repositorio
{
    public class FornecedorRepositorio
    {
        private List<Fornecedor> _fornecedores = new List<Fornecedor>();

        public void Inserir(Fornecedor fornecedor)
        {
            fornecedor.GerarId();
            _fornecedores.Add(fornecedor);
        }

        public Fornecedor BuscarPorId(Guid id)
        {
            return _fornecedores.FirstOrDefault(f => f.Id == id);
        }

        public List<Fornecedor> BuscarTodos()
        {
            return _fornecedores;
        }

        public void Atualizar(Fornecedor fornecedor)
        {
            var fornecedorLista = _fornecedores.FirstOrDefault(f => f.Id == fornecedor.Id);
            fornecedorLista = fornecedor;
        }

        public void Excluir(Guid id)
        {
            _fornecedores = _fornecedores.Where(f => f.Id != id).ToList();
        }
    }
}
