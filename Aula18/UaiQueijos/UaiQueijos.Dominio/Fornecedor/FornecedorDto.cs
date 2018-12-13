using System;

namespace UaiQueijos.Dominio.Fornecedor
{
    public class FornecedorDto
    {
        public Guid Id { get; set; }
        public DateTime DataInsercao { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string NomeFantasia { get; set; }
    }
}
