using System;
using Theos.PetShop.Comum.Helpers;
using Theos.PetShop.Dominio.Animais;
using Theos.PetShop.Dominio.Enumerador;

namespace Theos.PetShop
{
    class Program
    {
        public static string _nome = "";
        public static double _peso = 0.0;
        static void Main(string[] args)
        {
        
            double altura = 0.0;
            double largura = 0.0;
            double comprimento = 0.0;
          
            
            EAnimal opcao = (EAnimal)InputHelper.GetInputInt(@"Escolha uma das opções abaixo para cadastrar: 
1 - Cachorro
2 - Gato
3 - Peixe", "Entrada inválida");


            switch (opcao)
            {
                case EAnimal.Cachorro:
                    SolicitarInformacaoCachorro();
                    InputHelper.MensagemUsuario($"A limpeza do {_nome} ficará: ");
                    Cachorro cachorro = new Cachorro(_nome, _peso);
                    cachorro.CalculaLimpeza();
                    break;
                case EAnimal.Gato:

                    Gato gato = new Gato(_nome, _peso);
                    break;
                case EAnimal.Peixe:

                    Peixe peixe = new Peixe(_nome, altura, largura, comprimento);
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
       
        private static void SolicitarInformacaoCachorro()
        {
            InputHelper.MensagemUsuario("Digite o nome do seu cachorro");
            _nome = Console.ReadLine();
            Console.WriteLine("Digite o peso do seu cachorro");
            _peso = double.Parse(Console.ReadLine());
        }
    }
}
