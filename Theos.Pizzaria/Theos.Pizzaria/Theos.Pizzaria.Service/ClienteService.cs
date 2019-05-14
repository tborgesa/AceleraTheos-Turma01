using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.Pizzaria.Dominio.Cliente;
using Theos.Pizzaria.Dominio.Cliente.Interfaces;

namespace Theos.Pizzaria.Service
{
    public class ClienteService : IClienteService
    {

        private IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public ClienteDtoReturn Inserir(ClienteInserirViewModel clienteViewModel)
        {
            var cliente = new Cliente(clienteViewModel.Nome, clienteViewModel.CPF, clienteViewModel.Telefone, clienteViewModel.DataNascimento);

            if (!cliente.Valido())
                return new ClienteDtoReturn(cliente.GetErros());

            cliente.GerarId();
            _repository.Inserir(cliente);
            return new ClienteDtoReturn(BuscarPorId(cliente.Id));

        }

        public ClienteDtoReturn Atualizar(ClienteAtualizarViewModel clienteAtualizarViewModel)
        {
            var cliente = _repository.BuscarPorId(clienteAtualizarViewModel.Id);

            if(cliente == null)
            {
                var erros = new List<string>();
                erros.Add("O cliente que você está tentando atualizar não existe");
                return new ClienteDtoReturn(erros);
            }

            cliente.Alterar(clienteAtualizarViewModel.Nome, clienteAtualizarViewModel.CPF, clienteAtualizarViewModel.Telefone, clienteAtualizarViewModel.DataNascimento);
            cliente.SetarAlteracao();

            if (!cliente.Valido())
                return new ClienteDtoReturn(cliente.GetErros());

            _repository.Atualizar(cliente);
            return new ClienteDtoReturn(BuscarPorId(cliente.Id));
        }

        public ClienteDto BuscarPorId(Guid id)
        {
            var cliente = _repository.BuscarPorId(id);

            if (cliente == null)
                return null;

            return new ClienteDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone,
                CPF = cliente.CPF,
                DataNascimento = cliente.DataNascimento,
                DataInsercao = cliente.DataInsercao
            };
        }

        public List<ClienteSearchDto> BuscarTodos()
        {
            List<Cliente> clientes = _repository.BuscarTodos();

            List<ClienteSearchDto> retorno = new List<ClienteSearchDto>();
            foreach (var cliente in clientes)
            {
                retorno.Add(new ClienteSearchDto
                {
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    CPF = cliente.CPF,
                    Telefone = cliente.Telefone,
                    DataNascimento = cliente.DataNascimento                     
                });
            }

            return retorno;
        }

        public void Excluir(Guid id)
        {
            _repository.Excluir(id);
        }

    }
}
