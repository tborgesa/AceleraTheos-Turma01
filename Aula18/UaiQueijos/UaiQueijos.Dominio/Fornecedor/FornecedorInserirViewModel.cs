using System;

namespace UaiQueijos.Dominio.Fornecedor
{
    public class FornecedorInserirViewModel
    {
        public string Nome { get; set; } = "Thiago Borges Amaral";
        public string Cpf { get; set; } = "073.461.536-18";
        public DateTime DataNascimento { get; set; } = new DateTime(1987, 08, 07);
        public string Endereco { get; set; } = "Rua Teste";
        public string NomeFantasia { get; set; } = "Thiago Borges Amaral";
    }
}
