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
        static bool _sair = false;
        static List<AnimalAlias> _listaAnimais = new List<AnimalAlias>();
        static AnimalAlias _animal;
        static int _escolhaAnimal;
        static int _escolhaMenu;

        public static void Main(string[] args)
        {
            Menu();
            while (_sair == false)
            {
                switch (_escolhaMenu)
                {
                    case 1:
                        CadastrarAnimais();
                        break;
                    case 2:
                        Listagem();
                        break;
                    case 3:
                        Sair();
                        break;
                    default:
                        InputHelper.GetInputString("Opçao invalida, tente novamente");
                        break;

                }
                if (_escolhaMenu ==1)
                {
                    decimal precoLimpeza = _animal.CalculaPreco();
                    Console.WriteLine($"O preço da limpeza do {_nome} é R${precoLimpeza:c}");
                }
                Console.ReadKey();
                Menu();
            }
        }
        
        static void CriarGatoInserirLista()
        {
            _animal = ValoresAnimalTerrestre();
            _listaAnimais.Add(_animal);

        }
        static void CadastrarAnimais()
        {
            Console.WriteLine("o que tu quer cadastrar ? \n1 - Cadastrar Gato \n2 - Cadastrar Cachorro \n3 - Cadastrar Peixe");
            _escolhaAnimal = Convert.ToInt32(Console.ReadLine());
            switch (_escolhaAnimal)
            {
                case 1:
                    CriarGatoInserirLista();
                    break;
                case 2:
                    ValoresAnimalTerrestre();
                    CriarCachorroInserirLista();
                    break;
                case 3:
                    ValoresAnimalAquatico();
                    CriarPeixeInserirLista();
                    break;
                default:
                    return;
            }
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
            Console.Clear();
            Console.WriteLine("Menu PET SHOP \n1 - Cadastrar Animais \n2 - Listar animais \n3 - Sair");
            _escolhaMenu = Convert.ToInt32(Console.ReadLine());
        }
        static void Listagem()
        {
            
            Console.Clear();
            foreach (var animal in _listaAnimais)
            {
                Console.WriteLine($"{_animal.Nome} ");
            }
        }
        static void Sair()
        {
            Console.Clear();
            InputHelper.mensagemUsuario("vc saiu");
            _sair = false;
            //Environment.Exit(0);
        }
        static AnimalAlias ValoresAnimalTerrestre()
        {
            Console.Clear();
            _nome = InputHelper.GetInputString("Digite o nome do Animal");           
            _peso = InputHelper.GetInputDouble("Digite o peso do seu Animal", "Digite um peso valido");
            AnimalAlias animal = new GatoAlias(_nome, _peso);

            return animal;
        }
        static void ValoresAnimalAquatico()
        {
            Console.Clear();
            _nome = InputHelper.GetInputString("Digite o nome do Animal");
            _comprimento = InputHelper.GetInputDouble("Digite o comprimento do seu Animal", "Digite um comprimento valido");
            _largura = InputHelper.GetInputDouble("Digite a largura do seu Animal", "Digite uma largura valida");
            _altura = InputHelper.GetInputDouble("Digite a altura do seu Animal", "Digite uma altura valida");
        }
    }
}
