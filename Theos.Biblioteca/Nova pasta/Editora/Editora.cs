using System;

namespace Theos.Biblioteca.Dominio.Editora
{
    public class Editora
    {
        public Editora(string nome, string cnpj, string cep)
        {
            Nome = nome;
            Cnpj = cnpj;
            Cep = cep;
        }

        public string Nome { get; }
        public string Cnpj { get; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Cep { get; }

        public void AlteraLogradouro(string logradouro)
        {
            Logradouro = logradouro;
        }

        public void AlteraNumero(string numero)
        {
            Numero = numero;
        }
        public void AlteraBairro(string bairro)
        {
            Bairro = bairro;
        }
        public void AlteraCidade(string cidade)
        {
            Cidade = cidade;
        }

    }
}
