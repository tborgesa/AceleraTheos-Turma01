using System;
using System.Collections.Generic;

namespace UaiQueijos.Dominio.Fornecedor.Interfaces
{
    public interface IFornecedorRepositorio
    {
        void Inserir(Fornecedor fornecedor);
        void Atualizar(Fornecedor fornecedor);
        void Excluir(Guid id);
        Fornecedor BuscarPorId(Guid id);
        List<Fornecedor> BuscarTodos();
    }
}