using System;
using System.Collections.Generic;

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

    public class FornecedorDtoReturn
    {
        public FornecedorDtoReturn(FornecedorDto fornecedor)
        {
            Fornecedor = fornecedor;
            Erros = new List<string>();
        }

        public FornecedorDtoReturn(List<string> erros)
        {
            Erros = erros;
        }

        public FornecedorDto Fornecedor { get; }
        public List<string> Erros { get; }
    }
}
