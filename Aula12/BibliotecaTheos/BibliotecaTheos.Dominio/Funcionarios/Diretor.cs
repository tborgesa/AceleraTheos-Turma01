using System;
using BibliotecaTheos.Dominio.Setores;

namespace BibliotecaTheos.Dominio.Funcionarios
{
    class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf, Setor setor)
            : base (nome, cpf, setor)
        {

        }

        public bool FuncionarioDiretor { get; private set; }

        public void TornarDiretor()
        {
            FuncionarioDiretor = true;
        }

    }
}
