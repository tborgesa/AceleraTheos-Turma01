using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Dominio.Pessoa
{
    public abstract class Pessoa
    {
        public Pessoa(int codigo, string nome, string cpf)
        {
            Codigo = codigo;
            Nome = nome;
            Cpf = cpf;
        }
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }

    }
}
