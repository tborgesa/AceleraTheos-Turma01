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
        public ClienteDtoReturn Atualizar(ClienteAtualizarViewModel clienteAtualizarViewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteDto BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ClienteSearchDto> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            throw new NotImplementedException();
        }


        public ClienteDtoReturn Inserir(ClienteInserirViewModel clienteViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
