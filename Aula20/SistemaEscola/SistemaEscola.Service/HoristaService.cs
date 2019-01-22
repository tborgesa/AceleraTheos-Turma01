using System;
using System.Collections.Generic;
using SistemaEscola.Dominio.Horista;
using SistemaEscola.Dominio.Funcionario;
using SistemaEscola.Repositorio;
using SistemaEscola.Dominio;

namespace SistemaEscola.Service
{
    public class HoristaService
    {
        private HoristaRepositorio _repositorio = new HoristaRepositorio();

        public  HoristaDto Inserir(HoristaInserirViewModel horistaViewModel)
        {
            var horista = new Horista(horistaViewModel.Nome, horistaViewModel.Cpf, horistaViewModel.DataNascimento
                    , horistaViewModel.Endereco, horistaViewModel.Horas);

            _repositorio.Inserir(horista);

            return BuscarPorId(horista.Id);
        }

        public HoristaDto BuscarPorId(Guid id)
        {
            Horista horista = _repositorio.BuscarPorId(id);

            return new HoristaDto
            {
                Id = horista.Id,
                Cpf = horista.Cpf,
                DataInsercao = horista.DataInsercao,
                DataNascimento = horista.DataNascimento,
                Endereco = horista.Endereco,
                Nome = horista.Nome,
                Horas = horista.Horas
            };
        }

        public List<FuncionarioSearch> BuscarTodos()
        {
            List<Horista> horistas = _repositorio.BuscarTodos();

            List<FuncionarioSearch> retorno = new List<FuncionarioSearch>();

            foreach (var horista in horistas)
            {
                retorno.Add(new FuncionarioSearch
                {
                    Id = horista.Id,
                    Cpf = horista.Cpf,
                    Nome = horista.Nome,
                });
            }

            return retorno;
        }

        public HoristaDto Atualizar(HoristaAtualizarViewModel horistaAtualizarViewModel)
        {
            var horista = _repositorio.BuscarPorId(horistaAtualizarViewModel.Id);
            horista.AlterarEndereco(horistaAtualizarViewModel.Endereco);
            horista.AlterarHora(horistaAtualizarViewModel.Horas);
            horista.SetarAlteracao();

            _repositorio.Atualizar(horista);

            return BuscarPorId(horistaAtualizarViewModel.Id);
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}