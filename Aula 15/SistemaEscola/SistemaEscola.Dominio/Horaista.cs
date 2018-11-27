using System;

namespace SistemaEscola.Dominio.Funcionario
{
    public class Horaista : Funcionario
    {
        public string Horas;

        public Horaista(string nome, string horas):base(nome)
        {
            Horas = horas;
        }

        public override void Gravar()
        {
        }

        public override decimal SalarioFuncionario()
        {

            return 90 * 17;
        }
    }
}
