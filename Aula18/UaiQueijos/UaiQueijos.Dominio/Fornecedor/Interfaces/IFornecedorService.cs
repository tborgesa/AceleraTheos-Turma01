using System;
using System.Collections.Generic;

namespace UaiQueijos.Dominio.Fornecedor.Interfaces
{
    public interface IFornecedorService
    {
        FornecedorDtoReturn Inserir(FornecedorInserirViewModel fornecedorViewModel);
        FornecedorDto BuscarPorId(Guid id);
        List<FornecedorSearchDto> BuscarTodos();
        FornecedorDtoReturn Atualizar(FornecedorAtualizarViewModel fornecedorAtualizarViewModel);
        void Excluir(Guid id);
    }
}
