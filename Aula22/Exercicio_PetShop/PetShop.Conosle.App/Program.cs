using PetShop.Dominio.Animais;
using PetShop.Dominio.Animais.Enumerador;
using PetShop.Dominio.Pessoas;
using PetShop.Comum.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace PetShop.Conosle.App
{
    class Program
    {
        static string _MensagemErro { get; set; }
        static Cliente _dono;
        static Animal _animal;
        static double _valorLimpeza;

        static List<Animal> _animais = new List<Animal>();

        static void Main(string[] args)
        {
            while (true)
            {
                int opcao = MenuPrincipal();

                switch (opcao)
                {
                    case 1:
                        _dono = CadastrarCliente();
                        _animal = CadastrarAnimal(_dono);
                        _animais.Add(_animal);
                        _valorLimpeza = _animal.CalcularLimpeza();

                        Console.Clear();
                        Console.WriteLine($"***** DADOS CADASTRADOS COM SUCESSO *****" +
                            $"\nNome do Animal: {_animal.Nome}" +
                            $"\nValor da Limpeza: {_animal.ValorLimpeza.ToString("C", CultureInfo.CurrentCulture)}");

                        Console.ReadKey();
                        break;

                    case 2:
                        int menuLista = InputHelper.GetInputInt(@"ESCOLHA UMA OPÇÃO:
1 - Procurar animal pelo nome;
2 - Listar todos os animais;", "Opção inválida!");

                        ListarAnimais(menuLista);

                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Você digitou uma opção inválida, o sistema será finalizado. ");
                        break;
                }

            }
        }

        private static int MenuPrincipal()
        {
            while (true)
            {
                string menu = @"##### PET SHOP #####

Escolha a opção desejada:
1 - Calcular Limpeza;
2 - Listar Animais;
0 - SAIR;

Digite sua escolha abaixo: ";

                int opcao = InputHelper.GetInputInt(menu, "Opção Inválida!");

                if (opcao > 2)
                {
                    Console.WriteLine("Opção Inválida, tente novamente.");
                    Console.ReadKey();
                }
                else if (opcao == 0)
                    Environment.Exit(0);
                else
                {
                    Console.Clear();
                    return opcao;
                }
            }
        }

        private static Cliente CadastrarCliente()
        {
            Console.Write("Informe o nome do Dono do animal: ");
            string nome = Console.ReadLine();

            Console.Write("Informe o telefone do Dono do animal: ");
            string telefone = Console.ReadLine();

            Cliente cliente = new Cliente(nome, telefone);

            return cliente;
        }

        private static Animal CadastrarAnimal(Cliente dono)
        {
            EnumEspecie especie = InstanciarEspecie();

            switch (especie)
            {
                case EnumEspecie.Cachorro:
                    Console.Write("Informe o nome do cachorro: ");
                    string nomeCachorro = Console.ReadLine();
                    double pesoCachorro = (double)InputHelper.GetInputDouble("Informe o peso(kg) do cachorro: ", "Você digitou um valor inválido");

                    _animal = new Cachorro(nomeCachorro, _dono, EnumEspecie.Cachorro, pesoCachorro);

                    Console.Clear();
                    break;

                case EnumEspecie.Gato:

                    Console.Write("Informe o nome do gato: ");
                    string nomeGato = Console.ReadLine();
                    double pesoGato = (double)InputHelper.GetInputDouble("Informe o peso(kg) do gato: ", "Você digitou um valor inválido");

                    _animal = new Gato(nomeGato, _dono, EnumEspecie.Gato, pesoGato);

                    Console.Clear();
                    break;

                case EnumEspecie.Peixe:
                    Console.Write("Informe o nome do peixe: ");
                    string nomePeixe = Console.ReadLine();
                    double alturaPeixe = (double)InputHelper.GetInputDouble("Informe a altura do aquário: ", "Você digitou um valor inválido");
                    double larguraPeixe = (double)InputHelper.GetInputDouble("Informe a largura do aquário: ", "Você digitou um valor inválido");
                    double comprimentoPeixe = (double)InputHelper.GetInputDouble("Informe o comprimento do aquário: ", "Você digitou um valor inválido");

                    _animal = new Peixe(nomePeixe, dono, EnumEspecie.Peixe, alturaPeixe, larguraPeixe, comprimentoPeixe);

                    Console.Clear();
                    break;
            }

            return _animal;
        }

        private static EnumEspecie InstanciarEspecie()
        {
            EnumEspecie _especie = (EnumEspecie)InputHelper.GetInputInt("Escolha uma das opções para cadastrar o animal:" +
               "\n1 - Cachorro" +
               "\n2 - Gato" +
               "\n3 - Peixe" +
               "\n\nInforme a espécie do animal abaixo: ", "Opção Inválida!");

            Console.Clear();
            return _especie;
        }

        public static void ListarAnimais(int opcao)
        {
            _animais = _animais.OrderBy(_animal => _animal.Nome).ToList();

            if (opcao == 2)
            {
                Console.Clear();
                int i = 0;
                Console.WriteLine("*** ANIMAIS CADASTRADOS ***");
                foreach (var item in _animais)
                {
                    Console.WriteLine($"{i + 1} - {item.Nome}");
                    i++;
                }
            }
            else if (opcao == 1)
            {
                Console.Write("Digite o nome do animal: ");
                string nome = Console.ReadLine();

                Animal animalEncontrado = null;

                foreach (var item in _animais)
                {
                    if (item.Nome == nome)
                    {
                        Console.Clear();

                        animalEncontrado = item;
                        string resultadoBusca = @"*****REGISTRO ENCONTRADO*****

Nome do Animal: " + animalEncontrado.Nome
+ "\nDono do Animal: " + animalEncontrado.Cliente.Nome
+ "\nTelefone de Contato: " + animalEncontrado.Cliente.Telefone
+"\nValor da última limpeza: " + animalEncontrado.ValorLimpeza.ToString("C", CultureInfo.CurrentCulture);

                        Console.WriteLine(resultadoBusca);
                        break;
                    }
                }

                if(animalEncontrado == null)
                    Console.WriteLine("Animal não encontrado");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Opção inválida, tente novamente.");
                Console.ReadKey();
            }
        }
    }
}
