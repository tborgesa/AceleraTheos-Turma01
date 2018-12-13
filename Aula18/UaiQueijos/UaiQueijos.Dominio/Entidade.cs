using System;

namespace UaiQueijos.Dominio
{
    public abstract class Entidade
    {
        public Guid Id { get; private set; }
        public DateTime DataInsercao { get; }
        public DateTime DataAlteracao { get; private set; }

        public Entidade()
        {
            DataInsercao = DateTime.Now;
        }

        public void GerarId()
        {
            Id = Guid.NewGuid();
        }

        public void SetarAlteracao()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}
