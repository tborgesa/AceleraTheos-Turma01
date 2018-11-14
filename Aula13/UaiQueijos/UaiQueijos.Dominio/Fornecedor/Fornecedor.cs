using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiQueijos.Dominio.Fornecedor
{
    public class Fornecedor : Pessoa
    {
        public Fornecedor(DateTime dataNascimento, string cpf, string nome)
            : base(dataNascimento, cpf, nome)
        {
        }

        public Fornecedor(DateTime dataNascimento, string cpf, string nome, string endereco)
            : base(dataNascimento, cpf, nome, endereco)
        {
        }

        public override string CriarEmail()
        {
            int numero = 9;
            int numero1 = 0;
            
            int result = numero / numero1;

            return "Fornecedor: Feliz Natal e me de desconto ano que vem.";
        }
    }
}
