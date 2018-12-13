using System;

namespace UaiQueijos.Dominio.Fornecedor
{
    public class FornecedorAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Endereco { get; set; } = "";
    }
}
