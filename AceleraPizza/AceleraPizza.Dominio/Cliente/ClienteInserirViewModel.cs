using System;

namespace AceleraPizza.Dominio.Cliente
{
    public class ClienteInserirViewModel
    {
        public string Nome { get; set; } = "Christian Castilho";
        public string Cpf { get; set; } = "073.461.536-18";
        public DateTime DataNascimento { get; set; } = new DateTime(1992, 04, 03);
        public string Endereco { get; set; } = "Rua Teste";
        public string Telefone { get; set; } = "4430255000";
    }
}
