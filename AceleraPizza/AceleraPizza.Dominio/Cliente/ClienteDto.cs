﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Dominio.Cliente
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public DateTime DataInsercao { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
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