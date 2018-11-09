using System;
using BibliotecaTheos.Dominio.Setores;

namespace BibliotecaTheos.Dominio.Funcionarios
{
    class Lider : Funcionario

    {
        public Lider(string nome, string cpf, Setor setor)
            : base(nome, cpf, setor)
        {

        }

        public bool FuncionarioLider { get; private set }

        public void TornarLider()
        {
            FuncionarioLider = true;
        }

        public void DeixarDeSerLider()
        {
            FuncionarioLider = false;
        }
    }
}
