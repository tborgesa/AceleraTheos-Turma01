/*OBS: 
Use todos os 4 pilares de Orientação a Objeto(herança, polimorfismo, abstração e encapsulamento)
Use tambem os padrões de nomenclatura definidas nas aulas

Considere um sistema para um petshop:

Usar enum
*/

using System;
using AnimalAlias = PetShop.Dominio.Animal.Animal;
using CachorroAlias = PetShop.Dominio.Animal.Cachorro;
using GatoAlias = PetShop.Dominio.Animal.Gato;
using PeixeAlias = PetShop.Dominio.Animal.Peixe;

namespace PetShop.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;

            CachorroAlias cachorro = new CachorroAlias(100,1,2,0);
            Console.WriteLine(cachorro.ServicoLimpeza(cachorro.Peso));
            Console.ReadLine();

            Console.WriteLine("Cadastre o seu animal");
            switch (opcao)
            {
                case 1:
                    
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Valor");
                    break;
            }
        }
    }
}
