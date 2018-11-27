using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio01.Dominio.Animais
{
    public abstract class Animal
    {
        public Animal(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

        public abstract decimal CalculaPreco();


    }
}
