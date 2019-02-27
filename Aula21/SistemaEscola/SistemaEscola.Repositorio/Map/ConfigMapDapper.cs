using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;

namespace SistemaEscola.Repositorio.Map
{
    public class ConfigMapDapper
    {
        //Metodo para não carregar mais de uma vez.
        private static bool _jaCarregou;

        //Só pode carregar uma vez no sistema inteiro!!!
        //Inicialização do sistema não tem acesso ao repositorio.
        public static void Carregar()
        {
            if (_jaCarregou) return;

            //Quais são os mapeadores a configurar
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new ContratadoMap());
                config.AddMap(new HoristaMap());

                config.ForDommel();
                //Necessário para criar os INSERT, UDPATE, DELETE;
            });
        }
        //_jaCarregou true;

    }
}
