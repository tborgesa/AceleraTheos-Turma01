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

namespace Exercicio01.Console
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
            Tudo();
            System.Console.ReadKey();

        }



        static void Tudo()
        {
            if (_escolhaAnimal == 1)
            {
                ValoresAnimalTerrestre();
                CriarGatoInserirLista();
                Precao();
                Menu();
                Tudo();
            }
            else if (_escolhaAnimal == 2)
            {
                ValoresAnimalTerrestre();
                CriarCachorroInserirLista();
            }
            else if (_escolhaAnimal == 3)
            {
                ValoresAnimalAquatico();
                CriarPeixeInserirLista();
            }
            else if (_escolhaAnimal == 4)
            {
                Listagem();
            }
            else if (_escolhaAnimal == 5)
            {
                Sair();
            }
            else
            {
                InputHelper.GetInputString("Opçao invalida, tente novamente");
            }
            void Precao()
            {
                decimal precoLimpeza = _animal.CalculaPreco();
                System.Console.WriteLine($"O preço da limpeza do {_nome} é R${precoLimpeza:c}");
                System.Console.ReadKey();
            }
        }

        static void CriarGatoInserirLista()
        {
            _animal = new GatoAlias(_nome, _peso);
            _listaAnimais.Add(_animal);
        }

        static void CriarCachorroInserirLista()
        {
            _animal = new CachorroAlias(_nome, _peso);
            _listaAnimais.Add(_animal);
        }

        static void CriarPeixeInserirLista()
        {
            _animal = new PeixeAlias(_nome, _largura, _comprimento, _altura);
            _listaAnimais.Add(_animal);
        }

        static void Menu()
        {
            System.Console.Clear();
            System.Console.WriteLine("Menu PET SHOP \n1 - Cadastrar Gato \n2 - Cadastrar Cachorro \n3 - Cadastrar Peixe \n4 - Listar animais \n5 - Sair");
            _escolhaAnimal = Convert.ToInt32(System.Console.ReadLine());
        }

        static void Listagem()
        {
            System.Console.Clear();
            foreach (var animal in _listaAnimais)
            {
                System.Console.WriteLine($"{_animal.Nome} ");
            }
        }

        static void Sair()
        {
            System.Console.Clear();
            InputHelper.mensagemUsuario("vc saiu");
            _sair = false;
            //Environment.Exit(0);
        }

        static void ValoresAnimalTerrestre()
        {
            System.Console.Clear();
            _nome = InputHelper.GetInputString("Digite o nome do Animal");
            _peso = InputHelper.GetInputDouble("Digite o peso do seu Animal", "Digite um peso valido");
        }

        private static void ValoresAnimalAquatico()
        {
            System.Console.Clear();
            _nome = InputHelper.GetInputString("Digite o nome do Animal");
            _comprimento = InputHelper.GetInputDouble("Digite o comprimento do seu Animal", "Digite um comprimento valido");
            _largura = InputHelper.GetInputDouble("Digite a largura do seu Animal", "Digite uma largura valida");
            _altura = InputHelper.GetInputDouble("Digite a altura do seu Animal", "Digite uma altura valida");
        }
    }
}
