using System;

namespace Escola.Dominio
{
    public abstract class Professor
    {
		public int Codigo { get; set; }
		public string Nome { get; set; }

		public Professor(int codigo, string nome)
		{
			Codigo = codigo;
			Nome = nome;
		}

		public abstract double CalcularSalario();
    }
}
