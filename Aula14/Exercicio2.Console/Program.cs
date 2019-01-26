using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfessorAlias = Exercicio2.Dominio.Pessoa.Professor;


namespace Exercicio2.Console
{
    class Program
    {
        static bool _opcaoMenu;
        static List<ProfessorAlias> _listaProfessor = new List<ProfessorAlias>();
            
        static void Main(string[] args)
        {
            Menu();

            while (true)
            {
                switch (_opcaoMenu == true)
                {

                    default:
                        break;
                }
            }


        }

        static void ListarProfessor()
        {
            foreach (var professor in _listaProfessor)
            {
                System.Console.WriteLine($"{professor.Nome}");
            }
            System.Console.ReadKey();
        }

        static void Menu()
        {
            System.Console.WriteLine("1- Cadastrar \n2-Listar 3-Sair");
        }
    }
}
