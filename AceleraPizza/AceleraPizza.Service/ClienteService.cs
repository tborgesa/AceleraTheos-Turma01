using System;
using System.Collections.Generic;
using AceleraPizza.Dominio.Cliente;
using AceleraPizza.Dominio.Cliente.Interfaces;

namespace AceleraPizza.Service
{
    public class ClienteService : IClienteService
    {
        private IClienteRepositorio _repositorio;

        public ClienteService(IClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public ClienteDtoReturn Inserir(ClienteInserirViewModel clienteViewModel)
        {
            var cliente = new Cliente(
                clienteViewModel.Nome,
                clienteViewModel.Cpf,
                clienteViewModel.DataNascimento,
                clienteViewModel.Endereco,
                clienteViewModel.Telefone
                );

            if (!cliente.Valido())
                return new ClienteDtoReturn(cliente.GetErros());

            cliente.GerarId();
            _repositorio.Inserir(cliente);

            return new ClienteDtoReturn(BuscarPorId(cliente.Id));
        }

        public ClienteDto BuscarPorId(Guid id)
        {
            Cliente cliente = _repositorio.BuscarPorId(id);

            if (cliente == null)
                return null;

            return new ClienteDto
            {
                Id = cliente.Id,
                DataInsercao = cliente.DataInsercao,
                Nome = cliente.Nome,
                Cpf = cliente.Cpf,
                DataNascimento = cliente.DataNascimento,
                Endereco = cliente.Endereco,
                Telefone = cliente.Telefone
            };
        }

        public List<ClienteSearch> BuscarTodos()
        {
            List<Cliente> clientes = _repositorio.BuscarTodos();

            List<ClienteSearch> retorno = new List<ClienteSearch>();

            foreach (var cliente in clientes)
            {
                retorno.Add(new ClienteSearch
                {
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    Cpf = cliente.Cpf,
                });
            }

            return retorno;
        }

        public ClienteDtoReturn Atualizar(ClienteAtualizarViewModel clienteAtualizarViewModel)
        {
            var cliente = _repositorio.BuscarPorId(clienteAtualizarViewModel.Id);

            if (cliente == null)
            {
                var erros = new List<string>();
                erros.Add("Cliente não existe.");
                return new ClienteDtoReturn(erros);
            }

            cliente.AlterarEndereco(clienteAtualizarViewModel);
            cliente.SetarAlteracao();

            if (!cliente.Valido())
                return new ClienteDtoReturn(cliente.GetErros());

            _repositorio.Atualizar(cliente);

            return new ClienteDtoReturn(BuscarPorId(cliente.Id));
        }

        public void Excluir(Guid id)
        {
            //todo Validar se cliente não tem pedido.
            _repositorio.Excluir(id);
        }
    }
}