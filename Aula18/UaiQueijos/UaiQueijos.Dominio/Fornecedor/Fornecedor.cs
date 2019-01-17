﻿using System;

namespace UaiQueijos.Dominio.Fornecedor
{
    public class Fornecedor : Pessoa
    {
        public string NomeFantasia { get; }

        public Fornecedor(DateTime dataNascimento, string cpf, string nome, string nomeFantasia)
            : base(dataNascimento, cpf, nome)
        {
            NomeFantasia = nomeFantasia;
            ValidarNomeFantasia();
        }

        public Fornecedor(DateTime dataNascimento, string cpf, string nome, string endereco, string nomeFantasia)
            : base(dataNascimento, cpf, nome, endereco)
        {
            NomeFantasia = nomeFantasia;
            ValidarNomeFantasia();
        }

        public override string CriarEmail()
        {
            return $"Fornecedor {NomeFantasia}: Feliz Natal e me de desconto ano que vem.";
        }

        private void ValidarNomeFantasia()
        {
            if (string.IsNullOrWhiteSpace(NomeFantasia))
                AdicionarErro("Preecha o nome Fantasia");
        }
    }
}
