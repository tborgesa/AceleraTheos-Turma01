using System;
using System.Collections.Generic;

namespace PetShop.Dominio
{
    public abstract class Entidade
    {
        public Guid Id { get; private set; }
        public DateTime DataInsercao { get; }
        public DateTime DataAlteracao { get; private set; }
        private List<string> _erros = new List<string>();

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

        public List<string> GetErros()
        {
            return _erros;
        }

        public void AdicionarErro(string erro)
        {
            bool existe = false;

            foreach(string e in _erros)
            {
                if (e == erro)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
                _erros.Add(erro);
        }

        public bool Valido()
        {
            return _erros.Count == 0;
        }
    }
}
