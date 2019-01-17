using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Dominio
{
    public class Entidade
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
