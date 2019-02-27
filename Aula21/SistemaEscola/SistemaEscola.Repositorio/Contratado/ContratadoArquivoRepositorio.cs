using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Dominio.Funcionario;
using SistemaEscola.Comum.Helpers;
using Newtonsoft.Json;
using SistemaEscola.Dominio.Funcionario.Interfaces;

namespace SistemaEscola.Repositorio
{
    public class ContratadoArquivoRepositorio : IContratadoRepositorio
    {
        private List<Contratado> _contratados = new List<Contratado>();

        public ContratadoArquivoRepositorio()
        {
           // _contratados = GetContratadoArquivo();
            _contratados = DataBaseHelper.LerArquivo<Contratado>("Contratado");
        }

        public void Inserir(Contratado contratado)
        {
            contratado.GerarId();
            _contratados.Add(contratado);
            GravarContratadosArquvo(_contratados);
        }

        public Contratado BuscarPorId(Guid id)
        {
            var aux = _contratados.FirstOrDefault(f => f.Id == id);
            if (aux == null) return aux;
            aux.InstanciarEscolaridade();
            return aux;            
        }
        
        //public List<Contratado> GetContratadoArquivo()
        //{
        //    var conteudo = DataBaseHelper.LerArquivo("Contratado");
        //    var lista = JsonConvert.DeserializeObject<List<Contratado>>(conteudo);

        //    if (lista == null)
        //        lista = new List<Contratado>();

        //    return lista;
        //}

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

        private void GravarContratadosArquvo(List<Contratado> contratados)
        {
            var conteudo = JsonConvert.SerializeObject(contratados);
            DataBaseHelper.GravarArquivo(conteudo, "Contratado");
        }
    }
}
