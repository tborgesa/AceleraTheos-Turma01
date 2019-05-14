using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.Pizzaria.Dominio.Cliente
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInsercao { get; set; }
    }

    public class ClienteDtoReturn
    {
        public ClienteDtoReturn(ClienteDto cliente)
        {
            Cliente = cliente;
            Erros = new List<string>();
        }

        public ClienteDtoReturn(List<string> erros)
        {
            Erros = erros;
        }

        public ClienteDto Cliente { get; }
        public List<string> Erros { get; }
    }
}
