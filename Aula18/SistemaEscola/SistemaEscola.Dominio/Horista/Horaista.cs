using System;

namespace SistemaEscola.Dominio.Funcionario
{
    public class Horaista : Funcionario
    {
        public int Horas;

        public Horaista(DateTime dataNascimento, string nome, string cpf, int horas):base(nome, cpf, dataNascimento)
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
