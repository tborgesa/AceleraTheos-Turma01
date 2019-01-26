using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exercicio01.Dominio.Animais
{
    public abstract class Animal
    {
        public Guid Id { get; private set; }

        public void GerarId()
        {
           Id = Guid.NewGuid();
        }

        public Animal(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

        public abstract decimal CalculaPreco();

        public string AlterarNome(string novoNome)
        {
            Nome = novoNome;
            return novoNome;
        }
    }
}
