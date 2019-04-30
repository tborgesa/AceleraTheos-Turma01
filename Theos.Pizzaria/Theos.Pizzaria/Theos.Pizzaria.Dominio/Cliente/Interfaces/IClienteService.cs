using System;
using System.Collections.Generic;

namespace Theos.Pizzaria.Dominio.Cliente.Interfaces
{
    public interface IClienteService
    {
        ClienteDtoReturn Inserir(ClienteInserirViewModel clienteViewModel);
        ClienteDto BuscarPorId(Guid id);
        List<ClienteSearchDto> BuscarTodos();
        ClienteDtoReturn Atualizar(ClienteAtualizarViewModel clienteAtualizarViewModel);
        void Excluir(Guid id);
    }
}
