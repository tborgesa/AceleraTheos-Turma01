using System;
using Escola.Dominio.Professores.Enumerador;

namespace Escola.Dominio.Professores
{
    public class ProfessorHorista : Professor
    {
        public double CargaHoraria { get; private set; }

        public ProfessorHorista(string nome, EnumRegimeTrabalho regimeTrabalho, double cargahoraria)
            :base(nome, regimeTrabalho)
        {
            CargaHoraria = cargahoraria;
        }

        public override double CalcularSalario()
        {
            Salario = CargaHoraria * 17;
            return Salario;
        }
    }
}
