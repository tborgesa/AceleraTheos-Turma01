using System;

namespace SistemaEscola.Dominio.Funcionario
{
    public class Horaista : Funcionario
    {
        public int Horas;

        public Horaista(string nome, int horas):base(nome)
        {
            Horas = horas;
        }

        public override void Gravar()
        {
        }

        public override decimal SalarioFuncionario()
        {

            return Horas * 17;
        }
    }
}
