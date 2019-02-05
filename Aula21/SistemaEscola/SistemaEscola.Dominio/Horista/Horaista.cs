using System;

namespace SistemaEscola.Dominio.Funcionario
{
    public class Horista : Funcionario
    {
        public int Horas;

        public Horista()
        {

        }

        public Horista(string nome, string cpf, DateTime dataNascimento, string endereco, int horas):base(nome, cpf, dataNascimento,endereco)
        {
            Horas = horas;
            ValidaHoras(horas);
        }

        private void ValidaHoras(int horas)
        {
            if (horas < 0 || horas > 800)
            {
                AdicionarErro("Hora Invalida");
            }
        }

        public override void Gravar()
        {
        }

        public void AlterarHora(int horas)
        {
            Horas = horas;
            Console.WriteLine("Alterar Horas do Professor");
        }

        public override decimal SalarioFuncionario()
        {

            return Horas * 17;
        }
    }
}
