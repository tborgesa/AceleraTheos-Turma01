using PetShop.Dominio.Animais;
using PetShop.Dominio.Animais.Enumerador;
using PetShop.Dominio.Pessoas;
using PetShop.Comum.Helpers;
using System;

namespace PetShop.Conosle.App
{
    class Program
    {
        static string _MensagemErro { get; set; }
        static int _opcao;
        static Cliente _dono;
        static Animal _animal;
        static double _valorLimpeza;
        //static EnumEspecie _especie;

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

                        Console.WriteLine($"Cadastro Realizado com Sucesso...\nDADOS CADASTRAIS DO DONO" +
                            $"\nNome: {_dono.Nome}" +
                            $"\nCPF: {_dono.CPF}" +
                            $"\nTelefone: {_dono.Telefone}" +
                            $"\n\nDADOS CADASTRAIS DO ANIMAL" +
                            $"\nNome: {_animal.Nome}" +
                            $"\nData de Nascimento: {_animal.DataNascimento}" +
                            $"\nEspécie: {_animal.Especie}" +
                            $"\nDono: {_animal.Dono.Nome}" +
                            $"\n\nValor da Limpeza: R${_valorLimpeza}");
                        break;

                    case 2:
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
1 - Calcular Limpreza;
2 - SAIR;

Digite sua escolha abaixo: ", "Opção inválida!");

                Console.Clear();
                return opcao;
            }

        }

        private static Cliente CadastrarCliente()
        {
            Console.Write("Informe o nome do Dono do animal: ");
            string nome = Console.ReadLine();

            Console.Write("Informe o CPF do Dono do animal: ");
            string CPF = Console.ReadLine();

            Console.Write("Informe o telefone do Dono do animal: ");
            string telefone = Console.ReadLine();

            Cliente cliente = new Cliente(nome, CPF, telefone);

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

                    Console.Write("Informe a data de nascimento do animal, ou aperte ENTER para continuar: ");
                    string dataNascimentoCachorro = Console.ReadLine();

                    double pesoCachorro = (double)InputHelper.GetInputDouble("Informe o peso(kg) do cachorro: ", "Você digitou um valor inválido");

                    Cachorro cachorro = new Cachorro(nomeCachorro, _dono, especie, pesoCachorro);
                    _valorLimpeza = cachorro.CalcularLimpeza();
                    _animal = cachorro;

                    break;

                case EnumEspecie.Gato:

                    Console.Write("Informe o nome do gato: ");
                    string nomeGato = Console.ReadLine();

                    Console.Write($"Informe a data de nascimento do {nomeGato}, ou aperte ENTER para continuar: ");
                    string dataNascimentoGAto = Console.ReadLine();

                    double pesoGato = (double)InputHelper.GetInputDouble("Informe o peso(kg) do gato: ", "Você digitou um valor inválido");

                    Gato gato = new Gato(nomeGato, _dono, especie, pesoGato);

                    _animal = gato;

                    break;

                case EnumEspecie.Peixe:
                    Console.Write("Informe o nome do peixe: ");
                    string nomePeixe = Console.ReadLine();

                    Console.Write($"Informe a data de nascimento do {nomePeixe}, ou aperte ENTER para continuar: ");
                    string dataNascimentoPeixe = Console.ReadLine();

                    double alturaPeixe = (double)InputHelper.GetInputDouble("Informe a altura do aquário: ", "Você digitou um valor inválido");

                    double larguraPeixe = (double)InputHelper.GetInputDouble("Informe a largura do aquário: ", "Você digitou um valor inválido");

                    double comprimentoPeixe = (double)InputHelper.GetInputDouble("Informe o comprimento do aquário: ", "Você digitou um valor inválido");

                    Peixe peixe = new Peixe(nomePeixe, dono, especie, alturaPeixe, larguraPeixe, comprimentoPeixe);
                    _animal = peixe;

                    break;

                default:
                    break;
            }

            return _animal;

        }

        private static EnumEspecie InstanciarEspecie()
        {
            EnumEspecie _especie = (EnumEspecie)InputHelper.GetInputInt("\n\nEscolha uma das opções para cadastrar o animal:" +
               "\n1 - Cachorro;" +
               "\n2 - Gato;" +
               "\n3 - Peixe", "Opção Inválida!");

            return _especie;
        }
    }
}
