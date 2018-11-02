using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheosBiblioteca.Dominio.Cadastro.Funcionario
{
    public class Funcionario
    {
        public Funcionario(string nome, string cpf, string setor)
        {
            Nome = nome;
            Cpf = cpf;
            Setor = setor;
        }

        public string Nome { get; }
        public string Cpf { get; }
        public string Setor { get; }
    }
}