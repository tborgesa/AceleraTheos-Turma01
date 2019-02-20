using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.SistemaEscolar.Repositorio.Map
{
    public class ConfigMapDapper
    {

        private static bool _jaCarregou;

        public static void Carregar()
        {
            if (_jaCarregou) return;

            FluentMapper.Initialize(config =>
            {
                config.AddMap(new ProfessorHoristaMap());
                config.ForDommel();
            });

            _jaCarregou = true;

        }
    }
}
