using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheosBiblioteca.Dominio.Cadastro.Editora
{
    public class Editora
    {
        public Editora(string nome, string cnpj, string logradouro,
            string numero, string bairro, string cidade, string cep)
        {
            Nome = nome;
            Cnpj = cnpj;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Cep = cep;
        }

        public string Nome { get; }
        public string Cnpj { get; }
        public string Logradouro { get; }
        public string Numero { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public string Cep { get; }
    }
}
