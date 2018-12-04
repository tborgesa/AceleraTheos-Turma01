using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
	class Program
	{
		static void Main(string[] args)
		{

			//Console.WriteLine("*************** ARRAY ********************");

			//int[] numeros = new int[20];

			//numeros[0] = 45;
			//numeros[1] = 60;
			//numeros[4] = 56;

			//for (int i = 0; i < 20; i++)
			//{
			//    Console.WriteLine($"Numero posicão {i + 1}: {numeros[i]}");
			//}


			//Console.WriteLine("*************** LISTA ********************");

			//List<int> numerosLista = new List<int>();

			//numerosLista.Add(56);
			//numerosLista.Add(45);
			//numerosLista.Add(60);



			//Console.WriteLine("Lista com for");
			//for (int i = 0; i < numerosLista.Count; i++)
			//    Console.WriteLine($"Numero posicão {i + 1}: {numerosLista[i]}");

			//Console.WriteLine("Lista com foreach");
			//foreach (var numero in numerosLista)
			//    Console.WriteLine($"Numero: {numero}");

			//numerosLista.Sort();
			//Console.WriteLine("Lista ordenada");
			//foreach (var numero in numerosLista)
			//    Console.WriteLine($"Numero: {numero}");

			//numerosLista.Reverse();
			//Console.WriteLine("Lista ordenada decrescente");
			//foreach (var numero in numerosLista)
			//    Console.WriteLine($"Numero: {numero}");

			//numerosLista.Add(37);

			//Console.WriteLine("Lista ordenada e adicionada");
			//foreach (var numero in numerosLista)
			//    Console.WriteLine($"Numero: {numero}");

			//var numerosLista1 = new List<int>();

			//numerosLista1.Add(45);
			//numerosLista1.Add(67);
			//numerosLista1.Add(12);


			//numerosLista.AddRange(numerosLista1);

			//Console.WriteLine("Lista ordenada e adicionada outra lista");
			//foreach (var numero in numerosLista)
			//    Console.WriteLine($"Numero: {numero}");

			////Console.WriteLine("Lista limpa");
			////numerosLista.Clear();
			////foreach (var numero in numerosLista)
			////    Console.WriteLine($"Numero: {numero}");

			//Console.WriteLine("Quantidade de elementos em uma lista.");
			//if (numerosLista.Count == 0)
			//    Console.WriteLine("A lista esta vazia.");
			//else
			//    Console.WriteLine($"A lista contem {numerosLista.Count} elementos");

			//Console.WriteLine("Insert.");
			//numerosLista.Insert(5, 2);
			//foreach (var numero in numerosLista)
			//    Console.WriteLine($"Numero: {numero}");
/*
			Console.WriteLine("*************** LISTA DE ALUNOS********************");
			List<Aluno> alunos = new List<Aluno>();

			alunos.Add(new Aluno(5, "Thiago"));
			alunos.Add(new Aluno(6, "Castilho"));
			alunos.Add(new Aluno(3, "Aline"));
			alunos.Add(new Aluno(7, "Carol"));
			alunos.Add(new Aluno(1, "Rafael"));
			alunos.Add(new Aluno(2, "Talita"));
			alunos.Add(new Aluno(4, "Carlinho"));

			Console.WriteLine("lista desordenada");

			foreach (Aluno aluno in alunos)
			{
				Console.WriteLine($"{aluno.Codigo} - {aluno.Nome}");
			}

			Console.WriteLine("lista ordenada");
			alunos = alunos.OrderBy(a => a.Codigo).ToList();

			foreach (Aluno aluno in alunos)
			{
				Console.WriteLine($"{aluno.Codigo} - {aluno.Nome}");
			}

			Console.WriteLine("lista selecionada");
			List<string> nomeAlunos = alunos.Select(a => a.Nome).ToList();
			foreach (string nomeAluno in nomeAlunos)
			{
				Console.WriteLine(nomeAluno);
			}

			Console.WriteLine("lista filtro");
			List<Aluno> alunosFiltrados = alunos.Where(aluno => aluno.Codigo > 2).ToList();
			foreach (Aluno aluno in alunosFiltrados)
			{
				Console.WriteLine($"{aluno.Codigo} - {aluno.Nome}");
			}

			Console.WriteLine("lista filtro e selecionar");
			List<int> codigoAlunosFiltrados = alunos.OrderBy(aluno => aluno.Nome)
				.Where(aluno => aluno.Codigo > 2)
				.Select(aluno => aluno.Codigo).ToList();
			foreach (var codigoAluno in codigoAlunosFiltrados)
			{
				Console.WriteLine(codigoAluno);
			}


			Console.ReadKey();

*/
		}

	}
}

 
	 