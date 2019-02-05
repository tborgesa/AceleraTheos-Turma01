using System;
using System.Collections.Generic;

namespace SistemaEscola.Dominio.Horista
{
    public class HoristaDto
    {
        public Guid Id { get; set; }
        public DateTime DataInsercao { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public int Horas { get; set; }
    }

    public class HoristaDtoReturn
    {
        public HoristaDtoReturn(HoristaDto horista)
        {
            Horista = horista;
            Erros = new List<string>();
        }

        public HoristaDtoReturn(List<string> erros)
        {
            Erros = erros;
        }

        public HoristaDto Horista { get; }
        public List<string> Erros { get; }
    }

}
