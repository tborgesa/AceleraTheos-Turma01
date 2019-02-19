using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;

namespace UaiQueijos.Repositorio.Map
{
    public class ConfigMapDapper
    {
        private static bool _jaCarregou;

        public static void Carregar()
        {
            if (_jaCarregou) return; 

            FluentMapper.Initialize(config =>
            {
                config.AddMap(new FornecedorMap());

                config.ForDommel();
            });

            _jaCarregou = true;
        }
    }
}
