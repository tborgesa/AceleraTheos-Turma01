using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio
{
    public abstract class Entidade : BaseEntidade
    {
        //Virtual para sobrepor para mais de um mapeamento

        public virtual DateTime DataInsercao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }


        public Entidade()
        {
            DataInsercao = DateTime.Now;
        }

        public void SetarAlteracao()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}