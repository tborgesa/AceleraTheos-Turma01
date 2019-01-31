using System;
using System.Collections.Generic;
using System.Linq;
using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio.Fornecedor;
using Newtonsoft.Json;

namespace UaiQueijos.Repositorio
{
    public class FornecedorRepositorio
    {
        private List<Fornecedor> _fornecedores = new List<Fornecedor>();

        public FornecedorRepositorio()
        {
            _fornecedores = GetFornecedoresArquivo();
        }

        public void Inserir(Fornecedor fornecedor)
        {
            fornecedor.GerarId();
            _fornecedores.Add(fornecedor);
            GravarFornecedoresArquivo(_fornecedores);
        }

        public Fornecedor BuscarPorId(Guid id)
        {
            return _fornecedores.FirstOrDefault(f => f.Id == id);
        }

        public List<Fornecedor> BuscarTodos()
        {
            return _fornecedores;
        }

        public void Atualizar(Fornecedor fornecedor)
        {
            var fornecedorLista = _fornecedores.FirstOrDefault(f => f.Id == fornecedor.Id);
            fornecedorLista = fornecedor;
            GravarFornecedoresArquivo(_fornecedores);
        }

        public void Excluir(Guid id)
        {
            _fornecedores = _fornecedores.Where(f => f.Id != id).ToList();
            GravarFornecedoresArquivo(_fornecedores);
        }

        private List<Fornecedor> GetFornecedoresArquivo()
        {
            var conteudo = DataBaseHelper.LerArquivo("Fornecedor");
            var lista = JsonConvert.DeserializeObject<List<Fornecedor>>(conteudo);

            if (lista == null)
                lista = new List<Fornecedor>();

            return lista;
        }

        private void GravarFornecedoresArquivo(List<Fornecedor> fornecedores)
        {
            var conteudo = JsonConvert.SerializeObject(fornecedores);
            DataBaseHelper.GravarArquivo(conteudo, "Fornecedor");
        }
    }
}
