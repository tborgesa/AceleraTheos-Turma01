using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Dominio.Funcionario;
using SistemaEscola.Comum.Helpers;
using Newtonsoft.Json;

namespace SistemaEscola.Repositorio
{
    public class HoristaArquivoRepositorio
    {
        private List<Horista> _contratados = new List<Horista>();

        public HoristaArquivoRepositorio()
        {
            // _contratados = GetHoristaArquivo();
            _contratados = DataBaseHelper.LerArquivo<Horista>("Horista");
        }

        public void Inserir(Horista contratado)
        {
            contratado.GerarId();
            _contratados.Add(contratado);
            GravarHoristasArquvo(_contratados);
        }

        public Horista BuscarPorId(Guid id)
        {
            return _contratados.FirstOrDefault(f => f.Id == id);
        }

        //public List<Horista> GetHoristaArquivo()
        //{
        //    var conteudo = DataBaseHelper.LerArquivo("Horista");
        //    var lista = JsonConvert.DeserializeObject<List<Horista>>(conteudo);

        //    if (lista == null)
        //        lista = new List<Horista>();

        //    return lista;
        //}

        public List<Horista> BuscarTodos()
        {
            return _contratados;
        }

        public void Atualizar(Horista contratado)
        {
            var HoristaLista = _contratados.FirstOrDefault(f => f.Id == contratado.Id);
            HoristaLista = contratado;
            GravarHoristasArquvo(_contratados);
        }

        public void Excluir(Guid id)
        {
            _contratados = _contratados.Where(f => f.Id != id).ToList();
            GravarHoristasArquvo(_contratados);
        }

        private void GravarHoristasArquvo(List<Horista> contratados)
        {
            var conteudo = JsonConvert.SerializeObject(contratados);
            DataBaseHelper.GravarArquivo(conteudo, "Horista");
        }
    }
}
