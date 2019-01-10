/*OBS: 
Use todos os 4 pilares de Orientação a Objeto(herança, polimorfismo, abstração e encapsulamento)
Use tambem os padrões de nomenclatura definidas nas aulas

Considere um sistema para um petshop:
*/

using System;
//NAME SPACE
using AnimalAlias = PetShop.Dominio.Animal.Animal;
using CachorroAlias = PetShop.Dominio.Animal.Cachorro;
using GatoAlias = PetShop.Dominio.Animal.Gato;
using PeixeAlias = PetShop.Dominio.Animal.Peixe;
using HelpersAlias = PetShop.Comum.Helpers.InputHelper;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace PetShop.ConsoleApp
{
    class Program
    {
        public static List<AnimalAlias> animais = new List<AnimalAlias>();
        public static string erro = "Dado Invalido!";
        public static string removidoSucesso = "Removido com Sucesso!";
        public static string texto = "Digite uma opcao";
        public static string informeNome = "Informe o nome do Dono:";
        public static string informeCpf = "Informe o cpf do Dono:";
        public static string tela = "Informe a medida";
        public static string sistema = "==== PetShop ====\n";

        static void Main(string[] args)
        {
            telaMenu();
        }

        private static void telaMenu()
        {
            Console.WriteLine(sistema);
            var opcao = HelpersAlias.GetInputInt(texto + "\n01 - Cadastro\n" +
                "02 - Alterar\n" +
                "03 - Consulta\n" +
                "04 - Excluir\n" +
                "05 - Listar\n" +
                "06 - Sair", erro);
            switch (opcao)
            {
                case 1:
                    TipoAnimal();
                    break;
                case 2:
                    AlterarAnimal();
                    break;
                case 3:
                    ConsultarRegistro();
                    break;
                case 4:
                    ExcluirRegistro();
                    break;
                case 5:
                    ListaRegistro();
                    break;
                case 6:
                    return;
                default:
                    break;
            }

            telaMenu();
        }

        private static void ListaRegistro()
        {
            Console.Clear();
            if (animais.Count == 0)
            {
                HelpersAlias.PostString("Lista Vazia!");
                return;
            }
            else
            {
                foreach (AnimalAlias animal in animais)
                {
                    var horistaProfessor = animal as GatoAlias;

                    if (horistaProfessor == null)
                    {
                        var contratadoProfessor = animal as CachorroAlias;
                    }
                    else
                    {
                        var contratadoProfessor = animal as PeixeAlias;
                    }
                    ExibeDados(animal, false, false);
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }

        private static void ExibeDados(AnimalAlias animalConsultado, bool ReadKey = true, bool limparTela = true)
        {
            var salarioFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"),
                "{0:C}", animalConsultado.ServicoLimpeza());
            HelpersAlias.PostString($"Dados funcionário:\n" +
                        $"Nome: {animalConsultado.NomeDono}\n" +
                        $"Cpf: {animalConsultado.CpfDono}\n" +
                        $"Nome do Animal: {animalConsultado.NomeAnimal}\n" +
                        $"Valor da Limpeza: {salarioFormatado}", ReadKey, limparTela);
        }


        private static void ExcluirRegistro()
        {
            var cpf = HelpersAlias.GetInputString(informeCpf, erro);
            var funcionarioConsultado = animais.FirstOrDefault(cpfDono => cpfDono.CpfDono == cpf);
            Console.Clear();

            if (funcionarioConsultado == null)
            {
                HelpersAlias.PostString(erro);
            }
            else
            {
                ExibeDados(funcionarioConsultado);
                animais.Remove(funcionarioConsultado);
                HelpersAlias.PostString(removidoSucesso);
            }
        }

        private static void ConsultarRegistro()
        {
            var cpf = HelpersAlias.GetInputString(informeCpf, erro);
            var cpfDonoConsultado = animais.FirstOrDefault(professor => professor.CpfDono == cpf);
            Console.Clear();

            if (cpfDonoConsultado == null)
            {
                HelpersAlias.PostString(erro);
            }
            else
            {
                var animalConsultado = cpfDonoConsultado as CachorroAlias;

                if (animalConsultado == null)
                {
                    cpfDonoConsultado = cpfDonoConsultado as GatoAlias;
                }
                else if (true)
                {
                    cpfDonoConsultado = cpfDonoConsultado as PeixeAlias;
                }
                ExibeDados(cpfDonoConsultado);
            }
        }
        private static void TipoAnimal()
        {
            var nomeDono = getNomeDono();
            var cpfDono = getCpfDono();
            var nomeAnimal = getNomeAnimal();
            int opcao = HelpersAlias.GetInputSwicth("Escolha a opção do animal\n01-Cachorro\n02-Gato\n03-Peixe", erro,1,3);

            switch (opcao)
            {
                case 1:
                    ObjetoCachorro(nomeAnimal, nomeDono, cpfDono);
                    break;
                case 2:
                    ObjetoGato(nomeAnimal,nomeDono,cpfDono);
                    break;
                case 3:
                    ObjetoPeixe(nomeAnimal, nomeDono, cpfDono);
                    break;
                default:
                    Console.WriteLine(erro);
                    break;
            }
            Console.ReadKey();
        }

        private static string getNomeAnimal()
        {
            return HelpersAlias.GetInputString("Digite o nome do animal:", erro);
        }

        private static string getCpfDono()
        {
            return HelpersAlias.GetInputString("Digite o cpf do Dono:", erro);
        }

        private static string getNomeDono()
        {
            return HelpersAlias.GetInputString("Digite o nome do Dono:", erro);
        }

        private static void AlterarAnimal()
        {
            var cpfDono = HelpersAlias.GetInputString("Digite o cpf do dono:", "CPF invalido");
            var cpfDonoConsultado = animais.FirstOrDefault(dono => dono.CpfDono == cpfDono);

            if (cpfDonoConsultado == null)
            {
                HelpersAlias.PostString(erro);
            }
            else
            {
                var horistaProfessor = cpfDonoConsultado as AnimalAlias;
                animais.Where(cpfConsulta => cpfConsulta.CpfDono == cpfDono)
                           .Select(cpfConsulta => { cpfConsulta.CpfDono = getCpfDono() ; return cpfConsulta; })
                           .ToList();
                HelpersAlias.PostString("Alterado com Sucesso!");
            }
        }

        private static void ObjetoGato(string nomeAnimal, string nomeDono, string cpfDono)
        {
            animais.Add(new GatoAlias(nomeAnimal, nomeDono, cpfDono, GetPeso()));
            HelpersAlias.PostString("Cadastrado com sucesso");
        }

        private static decimal GetPeso()
        {
            return HelpersAlias.GetInputDecimal("Informe o peso do animal",erro);
        }

        private static void ObjetoCachorro(string nomeAnimal, string nomeDono, string cpfDono)
        {
            animais.Add(new CachorroAlias(nomeAnimal, nomeDono, cpfDono, GetPeso()));
            HelpersAlias.PostString("Cadastrado com sucesso");
        }

        private static void ObjetoPeixe(string nomeAnimal, string nomeDono, string cpfDono)
        {
            animais.Add(new PeixeAlias(nomeAnimal, nomeDono, cpfDono,
            HelpersAlias.GetInputDecimal(tela + ": altura do aquario", erro), 
            HelpersAlias.GetInputDecimal(tela + ": largura do aquario", erro), 
            HelpersAlias.GetInputDecimal(tela + ": Comprimento do aquario", erro)));
        }

        private static void ValorFinalServico(AnimalAlias animal)
        {
            Console.Clear();

            Console.WriteLine($"{"Valor Do Servico:"}\n" +
                $"\nNome do Animal:\n" +
                $"{animal.NomeAnimal}\n" +
                $"\nValor:\n" +
                $"{string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}",animal.ServicoLimpeza())}");
            Console.ReadKey();
        }
    }
}
