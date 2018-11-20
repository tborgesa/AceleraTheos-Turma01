using System;

namespace BibliotecaTheos.Dominio.Editoras.Editora
{
    public class Editora
    {
        public string Nome { get; private set; }
        private string Cnpj { get; }
        public string Logradouro { get; set; }
        public int NumeroLogradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public Editora(string nome, string cnpj)
        {
            Nome = nome;
            Cnpj = cnpj;
        }

        public Editora(string nome, string cnpj, string logradouro, int numeroLogradouro, string bairro, string cidade, string cep)
        {
            Nome = nome;
            Cnpj = cnpj;
            Logradouro = logradouro;
            NumeroLogradouro = numeroLogradouro;
            Bairro = bairro;
            Cidade = cidade;
            Cep = cep;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }
    }
}
