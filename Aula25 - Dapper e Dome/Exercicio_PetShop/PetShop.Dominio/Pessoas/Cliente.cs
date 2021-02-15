﻿using System;

namespace PetShop.Dominio.Pessoas
{
    public class Cliente : Entidade
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
            Validar();
        }

        public Cliente(string nome, string telefone, string endereco)
        {
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
