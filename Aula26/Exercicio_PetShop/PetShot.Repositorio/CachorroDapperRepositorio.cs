using PetShot.Repositorio;
using Dapper;
using Dommel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Dominio.Animais;

namespace PetShop.Repositorio
{
    public class CachorroDapperRepositorio : BaseRepositorio
    {
        public void Inserir(Cachorro cachorro)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(cachorro);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public Cachorro BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<Cachorro>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Cachorro> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<Cachorro>().ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar(Cachorro cachorro)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(cachorro);
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
                Conexao.Delete(new Cachorro() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }

        }
    }
}
