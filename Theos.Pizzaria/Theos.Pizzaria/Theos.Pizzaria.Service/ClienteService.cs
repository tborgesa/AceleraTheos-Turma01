using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.Pizzaria.Dominio.Cliente.Interfaces;

namespace Theos.Pizzaria.Service
{
    public class ClienteService : IClienteService
    {
        public string HelloWorld()
        {
            return "Hello World Service";
        }
    }
}
