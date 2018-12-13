using System;

namespace UaiQueijos.Dominio
{
    public abstract class Entidade
    {
        public Guid Id { get; private set; }

        public void GerarId()
        {
            Id = Guid.NewGuid();
        }

    }
}
