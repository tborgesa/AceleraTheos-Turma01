using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.Biblioteca.Dominio
{
    class Editora
    {
        public string Nome { get;  }
        public string Cnpj { get;  }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Cep { get; private set; }

        public Editora(string nome, string cnpj)
        {
            Nome = nome;
            Cnpj = cnpj;
        }

        public Editora(string nome, string cnpj, string logradouro, string numero, string bairro, string cidade, string cep)
        {
            Nome = nome;
            Cnpj = cnpj;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Cep = cep;
        }

    }
}
