using UaiQueijos.Dominio.Fornecedor;
using UaiQueijos.Repositorio;

namespace UaiQueijos.Service
{
    public class FornecedorService
    {
        public void Inserir (FornecedorInserirViewModel fornecedorViewModel)
        {
            var fornecedor = new Fornecedor(fornecedorViewModel.DataNascimento, fornecedorViewModel.Cpf, fornecedorViewModel.Nome
                    , fornecedorViewModel.Endereco, fornecedorViewModel.NomeFantasia);

            var repositorio = new FornecedorRepositorio();
            repositorio.Inserir(fornecedor);
        }
    }
}
