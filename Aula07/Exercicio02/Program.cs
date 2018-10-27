using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    //2) Escreva um programa que apresente quatro opções:
    //            -consulta saldo
    //           - saque
    //           - depósito
    //           - sair.
    //O saldo deve iniciar em R$ 0,00 e ele deve se atualizado com saque ou deposito.
    //O saldo não pode ser negativo.
    
    class Program
    {
        static decimal valorSaldo = 0.00m, valorSaque, valorDeposito;
        static string escolha;
        static bool saiu = false;
        static void Main(string[] args)
        {
            
            MenuEscolha();
            while (saiu == false)
            {
                
                if (!int.TryParse(escolha, out var escolhaSwitch ) && escolhaSwitch>0 && escolhaSwitch<5)
                {
                    Console.WriteLine("invalido");
                    MenuEscolha();
                }
               
                switch (escolhaSwitch)
                {
                    case 1:
                        Console.WriteLine($"O saldo é {valorSaldo:c2}");
                        Console.ReadKey();
                        Acao();
                        break;

                    case 2:
                        Sacar();
                        Acao();
                        break;
                    case 3:
                        Console.WriteLine("Qual valor de deposito?");
                        valorDeposito = Convert.ToDecimal(Console.ReadLine());
                        valorSaldo = valorSaldo + valorDeposito;
                        Acao();
                        break;
                    case 4:
                        Console.WriteLine("você saiu");
                        saiu = true;
                        break;
                        
                }
            }
            Console.ReadKey();
        }

        static void MenuEscolha()
        {
            Console.WriteLine("Escolha sua opcao \n1 - Consultar saldo \n2 - Saque \n3 - Depósito \n4 - sair");
            escolha = Console.ReadLine();
            
        }

        static void Acao()
        {
            Console.WriteLine("deseja realizar outra açao? \n1 - Sim \n2 - Sair");
            int simNao = Convert.ToInt32(Console.ReadLine());

            if (simNao == 1)
            {
                MenuEscolha();
            }
            else if(simNao == 2)
            {
                Console.WriteLine("você saiu");
                saiu = true;
                return;
            }

        }

        static void Sacar()
        {
            Console.WriteLine($"Limite disponível {valorSaldo:c2} \nQual valor deseja sacar?");
            valorSaque = Convert.ToDecimal(Console.ReadLine());

            if (valorSaldo >= valorSaque)
            {
                valorSaldo = valorSaldo - valorSaque;
            }

            else
            {
                Console.WriteLine("saldo insuficiente\n");
            }
        }        
    }
}
