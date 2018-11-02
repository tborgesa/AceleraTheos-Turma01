using System;
using Theos.Biblioteca.Comum.Helpers;
using FuncionarioAlias = Theos.Biblioteca.Dominio.Funcionario.Funcionario;

namespace Theos.Biblioteca.ConsoleApp
{
   class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Digite um nome: ");
            FuncionarioAlias funcionarioTeste = new FuncionarioAlias(Console.ReadLine(), "421.207.688-89", "Qualidade");

            InputHelper.MensagemUsuario($"Nome do funcionário: {funcionarioTeste.Nome}");

        }
    }
}
 