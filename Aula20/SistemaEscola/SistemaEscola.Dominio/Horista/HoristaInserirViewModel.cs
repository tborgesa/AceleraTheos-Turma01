using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Horista
{
    public class HoristaInserirViewModel
    {
        public string Nome { get; set; } = "";
        public string Cpf { get; set; } = "";
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; } = "";
        public int Horas { get; set; }
    }
}
