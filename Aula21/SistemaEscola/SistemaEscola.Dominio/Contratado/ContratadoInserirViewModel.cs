using System;
using SistemaEscola.Dominio.Escolaridade.Enumerador;

namespace SistemaEscola.Dominio.Contratado
{
    public class ContratadoInserirViewModel
    {
        public string Nome { get; set; } = "Christian Castilho";
        public string Cpf { get; set; } = "073.461.536-18";
        public DateTime DataNascimento { get; set; } = new DateTime(1992, 04, 03);
        public string Endereco { get; set; } = "Rua Teste";
        public EEscolaridade Escolaridade { get; set; } = EEscolaridade.Doutorado;
    }
}
