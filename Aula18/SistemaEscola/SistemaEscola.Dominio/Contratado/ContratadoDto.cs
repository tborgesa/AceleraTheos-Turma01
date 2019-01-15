using System;
using SistemaEscola.Dominio.Escolaridade.Enumerador;

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
        public EEscolaridade Escolaridade{ get; set; }
    }
}
