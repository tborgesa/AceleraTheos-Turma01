using System;
using EscolaridadeALias = SistemaEscola.Dominio.Escolaridade.Escolaridade;

namespace SistemaEscola.Dominio.Contratado
{
    public class ContratadoInserirViewModel
    {
        public string Nome { get; set; } = "";
        public string Cpf { get; set; } = "";
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; } = "";
        public EscolaridadeALias Escolaridade { get; set; }
    }
}
