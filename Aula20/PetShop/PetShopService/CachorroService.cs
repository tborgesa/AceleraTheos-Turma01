using System;
using System.Collections.Generic;
using pe
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopService
{
    public class CachorroService
    {
        private CahorroRepositorio _repositorio = new CahorroRepositorio();

        public CahorroDto Inserir(CahorroInserirViewModel contratadoViewModel)
        {
            var contratado = new Cahorro(
                contratadoViewModel.DataNascimento,
                contratadoViewModel.Nome,
                contratadoViewModel.Cpf,
                contratadoViewModel.Endereco,
                contratadoViewModel.Escolaridade);

            _repositorio.Inserir(contratado);

            return BuscarPorId(contratado.Id);
        }

        public CahorroDto BuscarPorId(Guid id)
        {
            Cahorro contratado = _repositorio.BuscarPorId(id);

            return new CahorroDto
            {
                Id = contratado.Id,
                Cpf = contratado.Cpf,
                DataInsercao = contratado.DataInsercao,
                DataNascimento = contratado.DataNascimento,
                Endereco = contratado.Endereco,
                Nome = contratado.Nome,
                Escolaridade = contratado.GetEEscolaridade()
            };
        }

        public List<FuncionarioSearch> BuscarTodos()
        {
            List<Cahorro> contratadoes = _repositorio.BuscarTodos();

            List<FuncionarioSearch> retorno = new List<FuncionarioSearch>();

            foreach (var contratado in contratadoes)
            {
                retorno.Add(new FuncionarioSearch
                {
                    Id = contratado.Id,
                    Cpf = contratado.Cpf,
                    Nome = contratado.Nome,
                });
            }

            return retorno;
        }

        public CahorroDto Atualizar(CahorroAtualizarViewModel contratadoAtualizarViewModel)
        {
            var contratado = _repositorio.BuscarPorId(contratadoAtualizarViewModel.Id);
            contratado.AlterarEndereco(contratadoAtualizarViewModel.Endereco);
            contratado.SetarAlteracao();

            _repositorio.Atualizar(contratado);

            return BuscarPorId(contratadoAtualizarViewModel.Id);
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}