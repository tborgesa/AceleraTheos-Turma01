using System;

namespace PetShop.Dominio.Animal
{
    public abstract class Animal
    {
        public string Nome;

        protected Animal(string nome)
        {
            Nome = nome;
        }

        public abstract decimal ServicoLimpeza();

        public abstract void Gravar();
    }
}
