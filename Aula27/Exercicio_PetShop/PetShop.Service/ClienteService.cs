using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Dominio.Pessoas;
using PetShop.Repositorio;
using static PetShop.Dominio.Pessoas.ClienteDto;
using PetShop.Dominio.Pessoas.Interfaces;

namespace PetShop.Service
{
    public class ClienteService : IClienteService
    {
        private IClienteRepositorio _repositorio;

        public ClienteService()
        {

        }

        public ClienteService(IClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public ClienteDtoReturn Inserir(ClienteInserirViewModel clienteViewModel)
        {
            var cliente = new Cliente(clienteViewModel.Nome, clienteViewModel.Telefone, clienteViewModel.Endereco);
            cliente.GerarId();

            if (!cliente.Valido())
                return new ClienteDtoReturn(cliente.GetErros());

            _repositorio.Inserir(cliente);
            return new ClienteDtoReturn(BuscarPorId(cliente.Id));
        }

        public ClienteDto BuscarPorId(Guid id)
        {
            Cliente cliente = _repositorio.BuscarPorId(id);

            return new ClienteDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone,
                Endereco = cliente.Endereco
            };
        }

        public Cliente BuscarModeloPorId(Guid id)
        {
            return _repositorio.BuscarPorId(id);
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
                    Telefone = cliente.Telefone,
                    Endereco = cliente.Endereco
                });
            }

            return retorno;
        }

        public ClienteDtoReturn Atualizar(ClienteAtualizarViewModel clienteAtualizarViewModel)
        {
            var cliente = _repositorio.BuscarPorId(clienteAtualizarViewModel.Id);
            var erros = new List<string>();

            if (cliente == null)
            {
                erros.Add("Cliente não existe.");
                return new ClienteDtoReturn(erros);
            }

            if (!cliente.Valido())
                return new ClienteDtoReturn(cliente.GetErros());


            cliente.AlterarEndereco(clienteAtualizarViewModel.Endereco);
            cliente.AlterarTelefone(clienteAtualizarViewModel.Telefone);
            cliente.SetarAlteracao();

            _repositorio.Atualizar(cliente);

            return new ClienteDtoReturn(BuscarPorId(clienteAtualizarViewModel.Id));
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}