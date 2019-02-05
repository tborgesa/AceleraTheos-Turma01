using System;
using System.Collections.Generic;
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

    public class ContratadoDtoReturn
    {
        public ContratadoDtoReturn(ContratadoDto contratado)
        {
            Contratado = contratado;
            Erros = new List<string>();
        }

        public ContratadoDtoReturn(List<string> erros)
        {
            Erros = erros;
        }

        public ContratadoDto Contratado { get; }
        public List<string> Erros { get; }
    }
}
