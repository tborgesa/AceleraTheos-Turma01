using System;

namespace Escola.Dominio
{ 
    public abstract class Contratado : Professor
    {
		public double ValorSalario { get; set; }

		public Contratado(int codigo, string nome, double valorSalario)
			: base(codigo, nome)
		{
			Codigo = codigo;
			Nome = nome;
			ValorSalario = valorSalario;
		}
	}
}
