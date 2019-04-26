using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Cliente.Interfaces
{
    public interface IClienteService
    {
        ClienteDtoReturn Inserir(ClienteInserirViewModel clienteViewModel);
        ClienteDto BuscarPorId(Guid id);
        List<ClienteSearch> BuscarTodos();
        ClienteDtoReturn Atualizar(ClienteAtualizarViewModel clienteAtualizarViewModel);
        void Excluir(Guid id);
    } 
}
