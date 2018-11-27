namespace Listas
{
    public class Aluno
    {
        public Aluno(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public int Codigo { get; }
        public string Nome { get; }
    }
}