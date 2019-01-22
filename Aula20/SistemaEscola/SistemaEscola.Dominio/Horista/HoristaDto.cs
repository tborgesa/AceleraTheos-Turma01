using System;

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
}
