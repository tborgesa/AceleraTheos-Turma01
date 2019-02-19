using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Horista
{
    public class HoristaInserirViewModel
    {
        public string Nome { get; set; } = "Horista Teste";
        public string Cpf { get; set; } = "490.142.580-38";
        public DateTime DataNascimento { get; set; } = new DateTime(1992, 04, 03);
        public string Endereco { get; set; } = "Teste de endereco";
        public int Horas { get; set; } = 2;
    }
}
