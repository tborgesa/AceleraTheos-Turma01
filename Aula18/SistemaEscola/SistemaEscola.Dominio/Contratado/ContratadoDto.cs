using System;
using EscolaridadeALias = SistemaEscola.Dominio.Escolaridade.Escolaridade;

namespace SistemaEscola.Dominio.Contratado
{
    public class ContratadoDto
    {
        public Guid Id { get; set; }
        public DateTime DataInsercao { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public EscolaridadeALias Escolaridade { get; set; }
    }
}
