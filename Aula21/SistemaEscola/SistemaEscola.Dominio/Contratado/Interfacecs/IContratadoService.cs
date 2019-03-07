using System;
using System.Collections.Generic;

namespace SistemaEscola.Dominio.Contratado.Interfacecs
{
    public interface IContratadoService
    {
        ContratadoDtoReturn Inserir(ContratadoInserirViewModel contratadoViewModel);
        ContratadoDto BuscarPorId(Guid id);
        List<FuncionarioSearch> BuscarTodos();
        ContratadoDtoReturn Atualizar(ContratadoAtualizarViewModel contratadoAtualizarViewModel);
        void Excluir(Guid id);  
    }
}
