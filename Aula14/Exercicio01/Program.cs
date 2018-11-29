using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Comum.Helpers;
using AnimalTerrestreAlias = Exercicio01.Dominio.Animais.AnimalTerrestre;
using AnimalAlias = Exercicio01.Dominio.Animais.Animal;
using CachorroAlias = Exercicio01.Dominio.Animais.Cachorro;
using GatoAlias = Exercicio01.Dominio.Animais.Gato;
using PeixeAlias = Exercicio01.Dominio.Animais.Peixe;

namespace Exercicio01
{
    class Program
    {
        static double _peso;
        static double _altura;
        static double _largura;
        static double _comprimento;
        static string _nome;
        static List<AnimalAlias> _listaAnimais = new List<AnimalAlias>();
        static AnimalAlias _animal = null;
        static int _escolhaAnimal;


        public static void Main(string[] args)
        {
            Menu();
            switch (_escolhaAnimal)
            {
                case 1:
                    ValoresAnimalTerrestre();
                    _animal = new GatoAlias(_nome, _peso);
                    _listaAnimais.Add(_animal);
                    break;
                case 2:
                    ValoresAnimalTerrestre();
                    _animal = new CachorroAlias(_nome, _peso);
                    break;
                case 3:
                    ValoresAnimalAquatico();
                    _animal = new PeixeAlias(_nome, _largura, _comprimento, _altura);
                    break;
                case 4:
                    Listagem();
                    break;
                case 5:
                    Sair();
                    break;
                default:
                    InputHelper.GetInputString("Opçao invalida, tente novamente");
                    return;

            }

            decimal precoLimpeza = _animal.CalculaPreco();
            Console.WriteLine($"O preço da limpeza do {_nome} é R${precoLimpeza:c}");
            Menu();
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu PET SHOP \n1 - Cadastrar Gato \n2 - Cadastrar Cachorro \n3 - Cadastrar Peixe \n4 - Listar animais \n5 - Sair");
            _escolhaAnimal = Convert.ToInt32(Console.ReadLine());
        }

        static void Listagem()
        {
            Console.Clear();
            foreach (var animall in _listaAnimais)
            {
                Console.WriteLine(_animal.Nome + "aqui é a lista");
            }
        }

        static void Sair()
        {
            Console.Clear();
            InputHelper.mensagemUsuario("vc saiu");
            Environment.Exit(0);
        }

        static void ValoresAnimalTerrestre()
        {
            Console.Clear();
            _nome = InputHelper.GetInputString("Digite o nome do Animal");           
            _peso = InputHelper.GetInputDouble("Digite o peso do seu Animal", "Digite um peso valido");
        }

        private static void ValoresAnimalAquatico()
        {
            Console.Clear();
            _nome = InputHelper.GetInputString("Digite o nome do Animal");
            _comprimento = InputHelper.GetInputDouble("Digite o comprimento do seu Animal", "Digite um comprimento valido");
            _largura = InputHelper.GetInputDouble("Digite a largura do seu Animal", "Digite uma largura valida");
            _altura = InputHelper.GetInputDouble("Digite a altura do seu Animal", "Digite uma altura valida");
        }
    }
}
