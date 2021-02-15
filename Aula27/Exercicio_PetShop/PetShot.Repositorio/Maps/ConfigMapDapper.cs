using Dapper.FluentMap.Dommel;
using Dapper.FluentMap;

namespace PetShop.Repositorio.Maps
{
    public class ConfigMapDapper
    {
        private static bool _carregado;
        
        public static void Carregar()
        {
            if (_carregado) return;

            FluentMapper.Initialize(config =>
            {
                config.AddMap(new EntidadeMap());
                config.AddMap(new CachorroMap());
                config.AddMap(new ClienteMap());
                config.ForDommel();
            });

            _carregado = true;
        }
    }
}
