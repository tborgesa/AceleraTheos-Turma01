using System;

namespace AceleraPizza.Dominio.Cliente
{
    public class ClienteAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Endereco { get; set; } = "";
        public string Telefone { get; set; } = "";
    }
}
