using System;

namespace PetShop.Dominio.Pessoas
{
    public class Cliente : Entidade
    {
        public string Nome { get; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }

        public Cliente(string nome, string telefone)
        {
            Console.WriteLine("Criando cliente sem endereço...");

            Nome = nome;
            Telefone = telefone;   
        }

        public Cliente(string nome, string telefone, string endereco)
        {
            Console.WriteLine("Criando cliente com endereço...");

            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        public void AlterarEndereco(string endereco)
        {

            Endereco = endereco;
        }

        public void AlterarTelefone(string telefone)
        {

            Telefone = telefone;
        }
    }
}
