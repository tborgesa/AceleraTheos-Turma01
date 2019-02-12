using System;
using System.Collections.Generic;
using System.Linq;
using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio.Fornecedor;
using Newtonsoft.Json;

namespace UaiQueijos.Repositorio
{
    public class FornecedorArquivoRepositorio
    {
        private List<Fornecedor> _fornecedores = new List<Fornecedor>();

        public FornecedorArquivoRepositorio()
        {
            _fornecedores = DataBaseHelper.LerArquivo<Fornecedor>("Fornecedor");
        }

        public void Inserir(Fornecedor fornecedor)
        {
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

        private void GravarFornecedoresArquivo(List<Fornecedor> fornecedores)
        {
            var conteudo = JsonConvert.SerializeObject(fornecedores);
            DataBaseHelper.GravarArquivo(conteudo, "Fornecedor");
        }
    }
}
