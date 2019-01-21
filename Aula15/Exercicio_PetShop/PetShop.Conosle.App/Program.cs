using PetShop.Dominio.Animais;
using PetShop.Dominio.Animais.Enumerador;
using PetShop.Dominio.Pessoas;
using PetShop.Comum.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetShop.Conosle.App
{
    class Program
    {
        static string _MensagemErro { get; set; }
        static int _opcao;
        static Cliente _dono;
        static Animal _animal;
        static List<Animal> _animais = new List<Animal>();
        static double _valorLimpeza;

        static void Main(string[] args)
        {

            _opcao = menuPrincipal();

            bool menu = true;

            while (menu)
            {

                switch (_opcao)
                {
                    case 1:
                        _dono = CadastrarCliente();
                        Animal animal = CadastrarAnimal(_dono);
                        _animais.Add(animal);
                        _valorLimpeza = animal.CalcularLimpeza();

                        Console.WriteLine($"Cadastro Realizado com Sucesso...\nDADOS CADASTRAIS DO DONO" +
                            $"\nNome: {_dono.Nome}" +
                            $"\nTelefone: {_dono.Telefone}" +
                            $"\n\nDADOS CADASTRAIS DO ANIMAL" +
                            $"\nNome: {_animal.Nome}" +
                            $"\nEspécie: {_animal.Especie}" +
                            $"\nDono: {_animal.Dono.Nome}" +
                            $"\n\nValor da Limpeza: R${_valorLimpeza}");

                        Console.ReadKey();
                        return;

                    case 2:
                        int i = _animais.Count();
                        Console.WriteLine($"Foram cadastrados {i} animal(is)");
                        _animais = _animais.OrderBy(a => _animal.Nome).ToList();

                        foreach (var bicho in _animais)
                        {
                            Console.WriteLine(_animal.Nome);
                        }

                        return;
                    case 0:
                        Console.WriteLine("Aperte qualquer tecla para encerrar o sistema... ");
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Você digitou uma opção inválida, o sistema será finalizado. ");
                        menu = false;
                        break;
                }
            }
            
            Console.ReadKey();
        }

        private static int menuPrincipal()
        {
            while (true)
            {

                int opcao = InputHelper.GetInputInt(@"##### PET SHOP #####

Escolha a opção desejada:
1 - Calcular limpreza;
2 - Listar animais;
0 - SAIR;

Digite sua escolha abaixo: ", "Opção inválida!");

                Console.Clear();
                return opcao;
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

                    _animal = new Cachorro(nomeCachorro, _dono, especie, pesoCachorro);
                   
                    Console.Clear();
                    break;

                case EnumEspecie.Gato:

                    Console.Write("Informe o nome do gato: ");
                    string nomeGato = Console.ReadLine();

                    double pesoGato = (double)InputHelper.GetInputDouble("Informe o peso(kg) do gato: ", "Você digitou um valor inválido");

                    _animal = new Gato(nomeGato, _dono, especie, pesoGato);

                    Console.Clear();
                    break;

                case EnumEspecie.Peixe:
                    Console.Write("Informe o nome do peixe: ");
                    string nomePeixe = Console.ReadLine();

                    double alturaPeixe = (double)InputHelper.GetInputDouble("Informe a altura do aquário: ", "Você digitou um valor inválido");

                    double larguraPeixe = (double)InputHelper.GetInputDouble("Informe a largura do aquário: ", "Você digitou um valor inválido");

                    double comprimentoPeixe = (double)InputHelper.GetInputDouble("Informe o comprimento do aquário: ", "Você digitou um valor inválido");

                    _animal = new Peixe(nomePeixe, dono, especie, alturaPeixe, larguraPeixe, comprimentoPeixe);

                    Console.Clear();
                    break;

                default:
                    break;
            }
            _animais.Add(_animal);
            return _animal;

        }

        private static EnumEspecie InstanciarEspecie()
        {
            EnumEspecie _especie = (EnumEspecie)InputHelper.GetInputInt("Escolha uma das opções para cadastrar o animal:" +
               "\n1 - Cachorro;" +
               "\n2 - Gato;" +
               "\n3 - Peixe;" +
               "\n\nInforme a espécie do animal abaixo: ", "Opção Inválida!");

            Console.Clear();

            return _especie;
        }
    }
}
