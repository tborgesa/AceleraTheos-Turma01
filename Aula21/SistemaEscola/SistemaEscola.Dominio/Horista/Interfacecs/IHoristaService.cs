using System;
using System.Collections.Generic;

namespace SistemaEscola.Dominio.Horista.Interfacecs
{
    public interface IHoristaService
    {
        HoristaDtoReturn Inserir(HoristaInserirViewModel contratadoViewModel);
        HoristaDto BuscarPorId(Guid id);
        List<FuncionarioSearch> BuscarTodos();
        HoristaDtoReturn Atualizar(HoristaAtualizarViewModel contratadoAtualizarViewModel);
        void Excluir(Guid id);  
    }
}
