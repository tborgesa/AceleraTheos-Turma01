using System;
using System.Collections.Generic;
using PetShop.Dominio.Pessoas;

namespace PetShop.Dominio.Pessoas.Interfaces
{
    public interface IClienteService
    {
        ClienteDto.ClienteDtoReturn Inserir(ClienteInserirViewModel clienteViewModel);
        ClienteDto BuscarPorId(Guid id);
        List<ClienteSearch> BuscarTodos();
        ClienteDto.ClienteDtoReturn Atualizar(ClienteAtualizarViewModel clienteAtualizarViewModel);
        void Excluir(Guid id);
    }
}
