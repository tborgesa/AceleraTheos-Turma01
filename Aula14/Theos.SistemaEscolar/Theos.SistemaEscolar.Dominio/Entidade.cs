using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.SistemaEscolar.Dominio
{
    public class Entidade
    {
        public Guid Id { get; set; }
        public DateTime DataInsercao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public List<string> _erros = new List<string>();

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
            bool existe = false;

            foreach (string e in _erros)
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
