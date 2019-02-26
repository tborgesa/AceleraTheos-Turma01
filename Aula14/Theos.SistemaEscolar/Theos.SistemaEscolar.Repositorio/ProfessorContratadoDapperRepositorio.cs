using Dommel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Interfaces;
using Theos.SistemaEscolar.Dominio.Professor;

namespace Theos.SistemaEscolar.Repositorio
{
    public class ProfessorContratadoDapperRepositorio : BaseRepositorio, IProfessorContratadoRepositorio
    {
        public void Inserir(ProfessorContratado professorContratado)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(professorContratado);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar(ProfessorContratado professorContratado)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(professorContratado);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public ProfessorContratado BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<ProfessorContratado>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<ProfessorContratado> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<ProfessorContratado>().ToList();
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
                Conexao.Delete(new ProfessorContratado() { Id = id });

            }
            finally
            {
                Conexao.Close();
            }
        }

    }
}
