using System;
using System.Collections.Generic;
using System.Linq;
using PetShop.Comum.Helpers;
using PetShop.Dominio.Animais;
using Newtonsoft.Json;

namespace PetShop.Repositorio
{
    public class CachorroRepositorio
    {
        private List<Cachorro> _cachorros = new List<Cachorro>();

        public void Inserir(Cachorro cachorro)
        {
            cachorro.GerarId();
            _cachorros.Add(cachorro);
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
        }

        public void Excluir(Guid id)
        {
            _cachorros = _cachorros.Where(c => c.Id != id).ToList();
        }

        private void GravarFornecedoresArquivos(List<Cachorro> cachorros)
        {
            var conteudo = JsonConvert.SerializeObject(cachorros);
            DataBaseHelper.GravarArquivo(conteudo, "Cachorros");
        }
    }
}
