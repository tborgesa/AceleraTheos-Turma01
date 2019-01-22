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
            Validar();
        }

        public Cliente(string nome, string telefone, string endereco)
        {
            Console.WriteLine("Criando cliente com endereço...");

            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Validar();
        }

        public void AlterarEndereco(string endereco)
        {
            Endereco = endereco;

            if (string.IsNullOrEmpty(endereco))
                AdicionarErro("Na alteração, o endereço é obrigatório.");
        }

        public void AlterarTelefone(string telefone)
        {
            Telefone = telefone;

            if (string.IsNullOrEmpty(telefone))
                AdicionarErro("Na alteração, o telefone é obrigatório.");
        }

        private void Validar()
        {
            if(string.IsNullOrWhiteSpace(Nome))
                AdicionarErro("Preencha o nome do cliente.");

            if(string.IsNullOrWhiteSpace(Telefone))
                AdicionarErro("Preencha o telefone do cliente.");

           // Telefone = 
        }
    }
}
