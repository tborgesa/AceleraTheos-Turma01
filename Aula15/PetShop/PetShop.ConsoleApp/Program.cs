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

namespace PetShop.ConsoleApp
{
    class Program
    {
        public static string erro = "Valor incorreto";
        public static string tela = "Informe os dados do animal";
        public static string telaValor = "Dados do serviço:";

        static void Main(string[] args)
        {
            Tela();
        }

        private static void Tela()
        {
            int opcao = HelpersAlias.GetInputInt("Escolha a opção do animal\n01-Cachorro\n02-Gato\n03-Peixe",erro);

            switch (opcao)
            {
                case 1:
                    ValorFinalServico(ObjetoCachorro());
                    break;
                case 2:
                    ValorFinalServico(ObjetoGato());
                    break;
                case 3:
                    ValorFinalServico(ObjetoPeixe());
                    break;
                default:
                    Console.WriteLine(erro);
                    break;
            }
            Console.ReadKey();
        }

        private static GatoAlias ObjetoGato()
        {
            var gato = new GatoAlias(HelpersAlias.GetInputString(tela + ": Nome", erro), HelpersAlias.GetInputDecimal(tela + ": Peso", erro));
            return gato;
        }

        private static CachorroAlias ObjetoCachorro()
        {
            var cachorro = new CachorroAlias(HelpersAlias.GetInputString(tela+": Nome",erro), HelpersAlias.GetInputDecimal(tela + ": Peso", erro));
            return cachorro;
        }

        private static PeixeAlias ObjetoPeixe()
        {
            var peixe = new PeixeAlias(
            HelpersAlias.GetInputString(tela + ": Nome", erro), 
            HelpersAlias.GetInputDecimal(tela + ": altura do aquario", erro), 
            HelpersAlias.GetInputDecimal(tela + ": largura do aquario", erro), 
            HelpersAlias.GetInputDecimal(tela + ": Comprimento do aquario", erro));
            return peixe;
        }

        private static void ValorFinalServico(AnimalAlias animal)
        {
            Console.Clear();

            Console.WriteLine($"{telaValor}\n" +
                $"\nNome do Animal:\n" +
                $"{animal.Nome}\n" +
                $"\nValor:\n" +
                $"{string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}",animal.ServicoLimpeza())}");
            Console.ReadKey();
        }
    }
}
