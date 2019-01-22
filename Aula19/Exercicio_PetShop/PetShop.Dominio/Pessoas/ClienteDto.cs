using System;
using System.Collections.Generic;

namespace PetShop.Dominio.Pessoas
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public class ClienteDtoReturn
        {
            public ClienteDto Cliente { get; }
            public List<string> Erros { get; }

            public ClienteDtoReturn(ClienteDto cliente)
            {
                Cliente = cliente;
                Erros = new List<string>();
            }

            public ClienteDtoReturn(List<string> erros)
            {
                Erros = erros;
            }
        }
    }
}
