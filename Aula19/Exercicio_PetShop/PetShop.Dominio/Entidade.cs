using System;


namespace PetShop.Dominio
{
    public abstract class Entidade
    {
        public Guid Id { get; private set; }
        public DateTime DataInsercao { get; }
        public DateTime DataAlteracao { get; private set; }

        public Entidade()
        {
            DataAlteracao = DateTime.Now;
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
