using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumAlias = Exercicio2.Dominio.Pessoa.Enum.EnumFormacao;

namespace Exercicio2.Dominio.Pessoa
{
    public class ProfessorContratado : Professor
    {
        public EnumAlias Formacao { get; private set; }

        public ProfessorContratado(int codigo, string nome, string cpf, string disciplina, decimal salario, EnumAlias formacao) : base(codigo, nome, cpf, disciplina, salario)
        {
            Formacao = formacao;
        }

        public override decimal SalarioProfessor(decimal salarioPorFormacao)
        {
            salarioPorFormacao = 0m;
            EnumAlias formacao = 0;
            switch (formacao)
            {
                case EnumAlias.SegundoGrau:
                    salarioPorFormacao = 1000m;
                    break;
                case EnumAlias.EnsinoSuperior:
                    salarioPorFormacao = 1800m;
                    break;
                case EnumAlias.Mestrado:
                    salarioPorFormacao = 3000m;
                    break;
                case EnumAlias.Doutorado:
                    salarioPorFormacao = 5000m;
                    break;
            }
            salarioPorFormacao = Salario;
            return salarioPorFormacao;  
        }

    }
}
