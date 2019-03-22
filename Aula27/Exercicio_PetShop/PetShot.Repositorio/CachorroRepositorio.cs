using System;
using System.Collections.Generic;
using System.Linq;
using PetShop.Comum.Helpers;
using PetShop.Dominio.Animais;
using Newtonsoft.Json;
using PetShop.Dominio.Animais.Interfaces;

namespace PetShop.Repositorio
{
    public class CachorroRepositorio : IAnimalRepositorio
    {
        private List<Cachorro> _cachorros = new List<Cachorro>();

        public CachorroRepositorio()
        {
            _cachorros = GetCachorrosArquivo();
        }

        public void Inserir(Cachorro cachorro)
        {
            cachorro.GerarId();
            _cachorros.Add(cachorro);
            GravarFornecedoresArquivos(_cachorros);
        }

        public Cachorro BuscarPorId(Guid id)
        {
            return _cachorros.FirstOrDefault(c => c.Id == id);
        }

        public List<Cachorro> BuscarTodos()
        {
            return _cachorros;
        }

        public void Atualizar(Cachorro cachorro)
        {
            var cachorroLista = _cachorros.FirstOrDefault(c => c.Id == cachorro.Id);
            cachorroLista = cachorro;
            GravarFornecedoresArquivos(_cachorros);
        }

        public void Excluir(Guid id)
        {
            _cachorros = _cachorros.Where(c => c.Id != id).ToList();
            GravarFornecedoresArquivos(_cachorros);
        }

        private void GravarFornecedoresArquivos(List<Cachorro> cachorros)
        {
            var conteudo = JsonConvert.SerializeObject(cachorros);
            DataBaseHelper.GravarArquivo(conteudo, "Cachorros");
        }

        private List<Cachorro> GetCachorrosArquivo()
        {
            var conteudo = DataBaseHelper.LerArquivo<Cachorro>("Cachorros").ToString();
            var lista = JsonConvert.DeserializeObject<List<Cachorro>>(conteudo);

            if (lista == null)
                lista = new List<Cachorro>();

            return lista;
        }
    }
}
