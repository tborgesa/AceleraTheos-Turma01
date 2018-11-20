using PetShop.Dominio.Animais;
using PetShop.Dominio.Animais.Enumerador;
using PetShop.Dominio.Pessoas;
using System;

namespace PetShop.Conosle.App
{
    class Program
    {
        static string _erro { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("***** PetShop *****");

            Cliente clienteJoao = new Cliente(
                "João Thiago", 
                "015.016.017-88", 
                "(44) 3326-6585");

            Cliente clientePriscila = new Cliente(
                "Priscila Oliveira",
                "012.013.014-05",
                "(45) 3225-8545",
                "Rua Euclides Mendes, 08 - Jd. Butantã - Campo Mourão/PR");

            clienteJoao.AlterarEndereco("Rua Doze de Outubro, 25 - Jd. Piratininga - Maringá/PR");
            clientePriscila.AlterarTelefone("(27) 99598-9878");

            Animal animal = new Animal("Peixe");
            //peixe.CalcularLimpeza(peixe.Altura, peixe.Largura, peixe.Comprimento);

            Console.WriteLine(
            
            Console.ReadKey();
        }

        private void InstanciarAnimal(EnumAnimal animal)
        {
            if (!Enum.IsDefined(typeof(EnumAnimal), animal))
            {
                _erro = "Tipo de animal inválido";
                return;
            }

            switch (animal)
            {
                case EnumAnimal.Peixe:
                    Animal = new Peixe();
                    break;
                case EnumAnimal.Gato:
                    break;
                case EnumAnimal.Cachorro:
                    break;
                default:
                    break;
            }
        }
    }
}
