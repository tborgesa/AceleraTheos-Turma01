using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio
{
    public abstract class Entidade
    {
        //Virtual para sobrepor para mais de um mapeamento
        public virtual Guid Id { get; set; }
        public virtual DateTime DataInsercao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
        private List<string> _erros = new List<string>();


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