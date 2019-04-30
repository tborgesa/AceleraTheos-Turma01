using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.Pizzaria.Dominio.Cliente.Interfaces
{
    public interface IClienteRepository
    {
        void Inserir(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(Guid id);
        Cliente BuscarPorId(Guid id);
        List<Cliente> BuscarTodos();
    }
}
