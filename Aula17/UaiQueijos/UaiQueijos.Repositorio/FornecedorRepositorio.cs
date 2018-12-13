using System.Collections.Generic;
using UaiQueijos.Dominio.Fornecedor;

namespace UaiQueijos.Repositorio
{
    public class FornecedorRepositorio
    {
        private List<Fornecedor> _fornecedores = new List<Fornecedor>();

        public void Inserir(Fornecedor fornecedor)
        {
            fornecedor.GerarId();
            _fornecedores.Add(fornecedor);
        }
    }
}
