using System;
using RegistroAutorALias = TheosBiblioteca.Dominio.Cadastro.Autor.Autor;

namespace TheosBiblioteca.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Numero pode não ser obrigatorio
            Console.WriteLine(@"Teste faça as inserções:
Editora
 Nome
 Cnpj
 Logradouro
 Numero
 Bairro
 Cidade
 Cep");


            Console.WriteLine(@"
Livro
 Nome
 Assunto
 Editora
 Autor");
            Console.WriteLine(@"
Funcionário
 Nome
 Cpf
 Setor");

            RegistroAutorALias autor = new RegistroAutorALias("Nome");

            var teste = autor.Nome;

            Console.WriteLine(teste);

            Console.ReadKey();
        }
    }
}
