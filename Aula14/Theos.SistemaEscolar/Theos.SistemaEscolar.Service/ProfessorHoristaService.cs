﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Professor;
using Theos.SistemaEscolar.Repositorio;

namespace Theos.SistemaEscolar.Service
{
    public class ProfessorHoristaService
    {
        //cria uma variável do tipo repositorio e instancia ela
        private ProfessorHoristaRepositorio _repositorio = new ProfessorHoristaRepositorio();

        //Será criado os métodos CRUD utilizando o viewModel como parametro com retorno de um Dto
        public ProfessorHoristaDto Inserir(ProfessorHoristaViewModel professorHoristaViewModel)
        {
            //cria uma variavel local do tipo ProfessorHorista, instancia e passa as propriedades por parametro
            var professorHorista = new ProfessorHorista(professorHoristaViewModel.Nome, professorHoristaViewModel.Cpf,
                professorHoristaViewModel.HorasTrabalhadas);

            //repositorio insere o que foi adicionado na variável local

            _repositorio.Inserir(professorHorista);

            return BuscarPorId(professorHorista.Id);
        }

        //Será criado um método retornando um Dto para buscar professorHorista por Id, recebendo como parametro um id
        public ProfessorHoristaDto BuscarPorId(Guid id)
        {
            ProfessorHorista professorHorista = _repositorio.BuscarPorId(id);

            if(professorHorista == null)
            {
                return null;
            }

            return new ProfessorHoristaDto
            {
                Id = professorHorista.Id,
                Cpf = professorHorista.Cpf,
                Nome =  professorHorista.Nome,
                HorasTrabalhadas = professorHorista.HorasTrabalhadas,
                DataInsercao = professorHorista.DataInsercao
            };

        }

        //Criar um método que retorna uma lista do tipo ProfessorHoristaSearch 
        public List<ProfessorHoristaSearch> BuscarTodos()
        {
            List<ProfessorHorista> professoresHoristas = _repositorio.BuscarTodos();
            List<ProfessorHoristaSearch> retorno = new List<ProfessorHoristaSearch>();

            foreach (var professorHorista in professoresHoristas)
            {
                retorno.Add(new ProfessorHoristaSearch
                {
                    Id = professorHorista.Id,
                    Cpf = professorHorista.Cpf,
                    Nome = professorHorista.Nome,
                    HorasTrabalhadas = professorHorista.HorasTrabalhadas
                });
            }

            return retorno;
        }

        //Será um método que retorna um dto de professor horista que recebe como parametro um atualizar view model
        public ProfessorHoristaDto Atualizar(ProfessorHoristaAtualizarViewModel professorHoristaAtualizarViewModel)
        {
            var professorHorista = _repositorio.BuscarPorId(professorHoristaAtualizarViewModel.Id);
            professorHorista.Alterar(professorHoristaAtualizarViewModel.Nome, professorHoristaAtualizarViewModel.Cpf);
            professorHorista.SetarAlteracao();

            _repositorio.Atualizar(professorHorista);

            return BuscarPorId(professorHoristaAtualizarViewModel.Id);
        }

        //Será um método que exclui, sem retorno e recebe um guid como parametro
        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}