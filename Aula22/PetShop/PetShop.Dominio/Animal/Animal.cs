using System;

namespace PetShop.Dominio.Animal
{
    public abstract class Animal : Entidade
    {
        public string NomeAnimal;
        public string NomeDono;
        public string CpfDono;

        protected Animal(string nomeAnimal, string nomeDono, string cpfDono)
        {
            NomeAnimal = nomeAnimal;
            NomeDono = nomeDono;
            CpfDono = cpfDono;
        }

        public abstract decimal ServicoLimpeza();

        public abstract void Gravar();
    }
}
