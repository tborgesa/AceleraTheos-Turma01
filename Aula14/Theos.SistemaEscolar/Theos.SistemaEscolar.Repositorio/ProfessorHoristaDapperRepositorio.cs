using Dommel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Interfaces;
using Theos.SistemaEscolar.Dominio.Professor;

namespace Theos.SistemaEscolar.Repositorio
{
    public class ProfessorHoristaDapperRepositorio : BaseRepositorio, IProfessorHoristaRepositorio
    {

        public void Inserir(ProfessorHorista professorHorista)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(professorHorista);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar(ProfessorHorista professorHorista)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(professorHorista);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Excluir(Guid id)
        {
            try
            {
                Conexao.Open();
                Conexao.Delete(new ProfessorHorista() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }

        public ProfessorHorista BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();

                return Conexao.Get<ProfessorHorista>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }


        public List<ProfessorHorista> BuscarTodos()
        {
            try
            {
                Conexao.Open();

                return Conexao.GetAll<ProfessorHorista>().ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
