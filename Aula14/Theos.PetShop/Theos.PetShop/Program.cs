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
        public static double _altura = 0.0;
        public static double _largura = 0.0;
        public static double _comprimento = 0.0;

        static void Main(string[] args)
        {

            double altura = 0.0;
            double largura = 0.0;
            double comprimento = 0.0;


            EAnimal opcao = (EAnimal)InputHelper.GetInputInt(@"Escolha uma das opções abaixo para cadastrar: 
1 - Cachorro
2 - Gato
3 - Peixe
4 - Sair", "Entrada inválida");

            Animal animal = null;
            switch (opcao)
            {
                case EAnimal.Cachorro:
                    SolicitarInformacaoCachorro();
                    animal = new Cachorro(_nome, _peso);
                    break;
                case EAnimal.Gato:
                    SolicitarInformacaoGato();
                    animal = new Gato(_nome, _peso);
                    break;
                case EAnimal.Peixe:
                    SolicitarInformacaoPeixe();
                    animal = new Peixe(_nome, altura, largura, comprimento);
                    break;
                case EAnimal.Sair:
                    Console.WriteLine("Saindo do sistema...");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                    return;
            }

            double valorLimpeza = animal.CalculaLimpeza();
            InputHelper.MensagemUsuario($"A limpeza do {_nome} ficará: {valorLimpeza:c}");
            Console.ReadKey();
        }

        private static void SolicitarInformacaoCachorro()
        {
            Console.WriteLine("Digite o nome do seu cachorro");
            _nome = Console.ReadLine();
            _peso = InputHelper.GetInputDouble("Digite o peso do seu cachorro", "Entrada inválida");
        }

        private static void SolicitarInformacaoGato()
        {
            Console.WriteLine("Digite o nome do seu gato");
            _nome = Console.ReadLine();
            _peso = InputHelper.GetInputDouble("Digite o peso do seu gato", "Entrada inválida");
        }

        private static void SolicitarInformacaoPeixe()
        {
            Console.WriteLine("Digite o nome do seu peixe");
            _nome = Console.ReadLine();
            Console.WriteLine("Digite a altura do aquário");
            _altura = InputHelper.GetInputDouble("Digite a altura do aquário", "Entrada inválida");
            _largura = InputHelper.GetInputDouble("Digite a largura do aquário", "Entrada inválida");
            _comprimento = InputHelper.GetInputDouble("Digite o comprimento do aquário", "Entrada inválida");
        }
    }
}
