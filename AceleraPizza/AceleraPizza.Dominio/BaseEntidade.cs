using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio
{
    public class BaseEntidade
    {
        public virtual Guid Id { get; set; }
        private List<string> _erros = new List<string>();


        public void GerarId()
        {
            Id = Guid.NewGuid();
        }

        public List<string> GetErros()
        {
            return _erros;
        }

        public void AdicionarErro(string erro)
        {
            if (!_erros.Exists(e => e == erro))
            {
                _erros.Add(erro);
            }
        }

        public bool Valido()
        {
            return _erros.Count == 0;
        }
    }
}
