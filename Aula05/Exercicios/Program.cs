using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicios Aula 05 - DateTime");
            Console.WriteLine();
            Console.WriteLine("ESCOLHA UMA OPÇÃO");
            Console.WriteLine("1. Identificar o primeiro dia do mês de um determinado pagamento.");
            Console.WriteLine("2. Identificar a data do fechamento contábil.");
            Console.WriteLine("3. Identificar a data de pagamento do imposto de uma nota fiscal.");
            Console.WriteLine("4. Calcular a senha do dia.");
            Console.WriteLine("5. Consulta de transação.");
            Console.WriteLine();

            Console.Write("Digite a opção desejada e tecle ENTER: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    /*1.A contabilização de uma determinada "Conta a Pagar" é feita sempre no primeiro dia do mês da data de emissão.
                    Solicite a data de emissão da conta a Pagar e retorne o primeiro dia do mês da emissão.*/
                    Console.WriteLine("Informe a data de emissão do pagamento (dd/mm/aaaa): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    DateTime primeirodia = new DateTime(data.Year, data.Month, 1);
                    Console.WriteLine($"O primeiro dia do mês da emissão desta conta é: {primeirodia: dd/MM/yyyy}");

                    break;

                case 2:
                    /*2.O fechamento contábil anual sempre acontece no ultimo dia do ano.
                    Solicite ao usuário o ano de fechamento e retorne a data que será feito o fechamento Contábil.*/
                    Console.WriteLine("Informe o ano do fechamento contábil: ");
                    int anofechamento = Convert.ToInt32(Console.ReadLine());

                    DateTime fechamento = new DateTime(anofechamento, 12, 31);
                    Console.WriteLine($"O fechamento contábil será realizado no dia {fechamento: dd/MM/yyyy}, que será na {fechamento.ToString("dddd", new CultureInfo("pt-br"))}.");

                    break;

                case 3:
                    /*3.Os impostos federais sempre são pagos no dia 15 no mês seguinte ao pagamento da Nota Fiscal.
                    Solicite ao usuário a data de emissão da Nota Fiscal e retorne a data que será paga o imposto.*/
                    Console.WriteLine("Informe a data de emissão da nota fiscal: ");
                    DateTime datanf = DateTime.Parse(Console.ReadLine());

                    DateTime messeguinte = datanf.AddMonths(1);
                    DateTime dataimposto = new DateTime(messeguinte.Date.Year, messeguinte.Date.Month, 15);

                    Console.WriteLine($"A data de pagamento do imposto da nota digitada é {dataimposto: dd/MM/yyyy}");

                    break;

                case 4:
                    /*4.Novamente a Senha do dia foi alterada. A nova regra diz que deverá somar o dia ao ano e do resultado 
                      multiplicar no mês. Do resultado ainda deverá ser dividido pelo dia semana acrescido de 1
                      (para evitar divisão por zero)*/
                    DateTime datadodia = DateTime.Now;

                    int dia = datadodia.Date.Day;
                    int mes = datadodia.Date.Month;
                    int ano = datadodia.Date.Year;
                    int semana = Convert.ToInt32(datadodia.Date.DayOfWeek) + 1;

                    int senha = ((dia + ano) * mes) / semana;
                    Console.WriteLine($"A senha do dia de hoje {datadodia: dd/MM/yyyy} é: {senha}");

                    break;

                case 5:
                    /*5. As transações de cartão do banco de dados armazenam a data e hora da transação.
                    Solicite a data de filtro para o usuário e retorno a data de inicio e data de fim que é capaz de 
                    buscar todas as transações da data solicitada.*/
                    Console.WriteLine("Informe a data da transação:");
                    DateTime datatrans = DateTime.Parse(Console.ReadLine());

                    DateTime datainicial = new DateTime(datatrans.Date.Year, datatrans.Date.Month, datatrans.Date.Day, 00, 00, 00);
                    DateTime datafinal = new DateTime(datatrans.Date.Year, datatrans.Date.Month, datatrans.Date.Day, 23, 59, 59);

                    Console.WriteLine($"A busca acontecerá entre a data/hora inicial: {datainicial} e data/hora final: {datafinal}");

                    break;
            }

            Console.ReadKey();
        }
    }
}
