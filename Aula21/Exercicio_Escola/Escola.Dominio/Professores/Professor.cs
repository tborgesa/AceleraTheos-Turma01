using System;
using Escola.Dominio.Professores.Enumerador;

namespace Escola.Dominio.Professores
{
    public abstract class Professor
    {
        public string Nome { get; private set; }
        public EnumRegimeTrabalho RegimeTrabalho { get; private set; }
        public double Salario;

        public Professor(string nome, EnumRegimeTrabalho regimeTrabalho)
        {
            Nome = nome;
            RegimeTrabalho = regimeTrabalho;
        }

        public abstract double CalcularSalario();
    }
}
