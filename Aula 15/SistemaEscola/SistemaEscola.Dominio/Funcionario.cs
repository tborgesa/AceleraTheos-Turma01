using SistemaEscola.Dominio.Escolaridade;
using SistemaEscola.Dominio.Escolaridade.Enumerador;
using System;

namespace SistemaEscola.Dominio.Funcionario
{
    public abstract class Funcionario
    {
        public string Nome { get; }
        public decimal Salario { get; }

        protected Funcionario(string nome, decimal salario)
        {
            Salario = salario;
            Nome = nome;

        }

        public abstract  decimal SalarioFuncionario();

        public abstract void Gravar();

    }
}
