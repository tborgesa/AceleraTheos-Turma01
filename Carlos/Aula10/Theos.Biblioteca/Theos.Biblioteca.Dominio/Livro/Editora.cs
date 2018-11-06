using System;
using Theos.Biblioteca.Comum;

namespace Theos.Biblioteca.Dominio
{
    public class Editora
    {
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

        public string Nome { get; }
        public string Cnpj { get; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Cep { get; private set; }

        public void AlterarLogradouro(string logradouro)
        {
            Logradouro = logradouro;
        }

        public void AlterarNumero(string numero)
        {
            Numero = numero;
        }

        public void AlterarBairro(string bairro)
        {
            Bairro = bairro;
        }

        public void AlterarCidade(string cidade)
        {
            Cidade = cidade;
        }

        public void AlterarCep(string cep)
        {
            Cep = cep;
        }
    }
}
