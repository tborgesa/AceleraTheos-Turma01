using System;

namespace Escola.Dominio
{ 
    public abstract class Contratado : Professor
    {
		public double ValorSalario { get; set; }

		public Contratado(double valorSalario, int codigo, string nome)
			: base(codigo, nome)
		{
			Codigo = codigo;
			Nome = nome;
			ValorSalario = valorSalario;
		}
	}
}
