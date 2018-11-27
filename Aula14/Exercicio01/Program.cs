using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Comum.Helpers;
using AnimalAlias = Exercicio01.Dominio.Animais.Animal;
using CachorroAlias = Exercicio01.Dominio.Animais.Cachorro;
using GatoAlias = Exercicio01.Dominio.Animais.Gato;
using PeixeAlias = Exercicio01.Dominio.Animais.Peixe;

namespace Exercicio01
{
    class Program
    {
        static double peso;
        static double altura;
        static double largura;
        static double comprimento;
        static string nome;       

        static void Main(string[] args)
        {
            Console.WriteLine("Qual animal você quer calcular a limpeza? \n1 Gato \n2 Cao \n3 Peixe");
            AnimalAlias animal = null;
            int escolhaAnimal = Convert.ToInt32(Console.ReadLine());

            switch (escolhaAnimal)
            {
                case 1:
                    ValoresAnimalTerrestre();
                    animal = new GatoAlias(nome,peso);
                    Console.ReadKey();
                    break;
                case 2:
                    ValoresAnimalTerrestre();
                    animal = new CachorroAlias(nome,peso);
                    break;
                case 3:
                    ValoresAnimalAquatico();
                    animal = new PeixeAlias(nome,largura,comprimento,altura);
                    break;
                default:
                    InputHelper.GetInputString("Opçao invalida, tente novamente");
                    return;
                
            }
            Console.WriteLine($"O preço da limpeza do {animal.Nome} é R${animal.CalculaPreco():n2}");
            Console.ReadKey();
        }



        static void ValoresAnimalTerrestre()
        {
            nome = InputHelper.GetInputString("Digite o nome do Animal");
            peso = InputHelper.GetInputDouble("Digite o peso do seu Animal", "Digite um peso valido");
        }

        private static void ValoresAnimalAquatico()
        {
            nome = InputHelper.GetInputString("Digite o nome do Animal");
            comprimento = InputHelper.GetInputDouble("Digite o comprimento do seu Animal", "Digite um comprimento valido");
            largura = InputHelper.GetInputDouble("Digite a largura do seu Animal", "Digite uma largura valida");
            altura = InputHelper.GetInputDouble("Digite a altura do seu Animal", "Digite uma altura valida");
        }
    }
}
