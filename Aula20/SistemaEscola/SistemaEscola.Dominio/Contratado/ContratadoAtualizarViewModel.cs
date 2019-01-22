using System;
using SistemaEscola.Dominio.Escolaridade.Enumerador;

namespace SistemaEscola.Dominio.Contratado
{
    public class ContratadoAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Endereco { get; set; } = "";
        public  EEscolaridade Escolaridade{ get; set; }
    }
}
