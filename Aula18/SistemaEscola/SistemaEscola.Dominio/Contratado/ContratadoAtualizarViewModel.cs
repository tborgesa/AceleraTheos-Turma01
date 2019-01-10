using System;
using EscolaridadeALias = SistemaEscola.Dominio.Escolaridade.Escolaridade;


namespace SistemaEscola.Dominio.Contratado
{
    public class ContratadoAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Endereco { get; set; } = "";
        public EscolaridadeALias Escolaridade { get; set; }
    }
}
