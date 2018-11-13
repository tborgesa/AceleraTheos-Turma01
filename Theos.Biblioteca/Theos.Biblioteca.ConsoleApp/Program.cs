using System;
using Theos.Biblioteca.Comum.Helpers;
using SetorAlias = Theos.Biblioteca.Dominio.Setor.Setor;
using FuncionarioAlias = Theos.Biblioteca.Dominio.Funcionario.Funcionario;
using Theos.Biblioteca.Dominio.Setor.Enumerador;

namespace Theos.Biblioteca.ConsoleApp
{
   class Program
    {
        static void Main(string[] args)
        {
            SetorAlias setor = new SetorAlias("Qualidade");

            var permissoes = setor.GetPermissao();

            Console.WriteLine("Digite um nome: ");
            FuncionarioAlias funcionarioTeste = new FuncionarioAlias(Console.ReadLine(), "421.207.688-89", (ESetor)7);

           
           
            InputHelper.MensagemUsuario($@"Nome do funcionário: {funcionarioTeste.Nome}
CPF: {funcionarioTeste.Cpf}
Setor: {funcionarioTeste.Setor.Nome}
Setor pode alterar? {funcionarioTeste.GetPermissao().AlterarLivro}");


         
        }
    }
}
 