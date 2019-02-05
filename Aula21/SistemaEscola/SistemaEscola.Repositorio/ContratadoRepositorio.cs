using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Dominio.Funcionario;
using SistemaEscola.Comum.Helpers;
using Newtonsoft.Json;

namespace SistemaEscola.Repositorio
{
    public class ContratadoRepositorio
    {
        private List<Contratado> _contratados = new List<Contratado>();

        public ContratadoRepositorio()
        {
            _contratados = GetContratadoArquivo();
        }

        public void Inserir(Contratado contratado)
        {
            contratado.GerarId();
            _contratados.Add(contratado);
            GravarContratadosArquvo(_contratados);
        }

        public Contratado BuscarPorId(Guid id)
        {
            return _contratados.FirstOrDefault(f => f.Id == id);
        }

        public List<Contratado> BuscarTodos()
        {
            return _contratados;
        }

        public void Atualizar(Contratado contratado)
        {
            var ContratadoLista = _contratados.FirstOrDefault(f => f.Id == contratado.Id);
            ContratadoLista = contratado;
            GravarContratadosArquvo(_contratados);
        }

        public void Excluir(Guid id)
        {
            _contratados = _contratados.Where(f => f.Id != id).ToList();
            GravarContratadosArquvo(_contratados);
        }

        public List<Contratado> GetContratadoArquivo()
        {
            var conteudo = DataBaseHelper.LerArquivo("Contratado");
            var lista = JsonConvert.DeserializeObject<List<Contratado>>(conteudo);

            if (lista == null)
                lista = new List<Contratado>();

            return lista;
        }

        private void GravarContratadosArquvo(List<Contratado> contratados)
        {
            var conteudo = JsonConvert.SerializeObject(contratados);
            DataBaseHelper.GravarArquivo(conteudo, "Contratado");
        }
    }
}
