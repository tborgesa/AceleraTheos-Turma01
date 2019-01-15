using System;

namespace SistemaEscola.Dominio.Funcionario
{
    public class Horista : Funcionario
    {
        public int Horas;

        public Horista(DateTime dataNascimento, string nome, string cpf, string endereco, int horas):base(nome, cpf, dataNascimento)
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
