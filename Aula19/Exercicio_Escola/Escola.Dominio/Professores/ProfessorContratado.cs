using System;
using Escola.Dominio.Professores.Enumerador;

namespace Escola.Dominio.Professores
{
    public class ProfessorContratado : Professor
    {
        public EnumFormacao Formacao { get; set; }

        public ProfessorContratado(string nome, EnumRegimeTrabalho regimeTrabalho,  EnumFormacao formacao)
            :base(nome, regimeTrabalho)
        {
            Formacao = formacao;
        }

        public override double CalcularSalario()
        {
            double _salario = 0; 
            switch (Formacao)
            {
                case EnumFormacao.SegundoGrau:
                    _salario = 1000;
                    break;
                case EnumFormacao.EnsinoSuperior:
                    _salario = 1800;
                    break;
                case EnumFormacao.Mestrado:
                    _salario = 3000;
                    break;
                case EnumFormacao.Doutorado:
                    _salario = 5000;
                    break;
                default:
                    break;
            }
            Salario = _salario;

            return Salario;
        }

    }
}
