using AceleraPizza.Dominio.Cliente.Interfaces;
using AceleraPizza.Repositorio;
using Unity;
using Unity.Lifetime;
using System.Configuration;
using AceleraPizza.Repositorio;

namespace AceleraPizza.InjecaoDependencia
{
    public class RepositoryRegister
    {
        public static void Register(IUnityContainer container)
        {
            RegisterDapperNet(container);
            //var tipoBancoDados = int.Parse(ConfigurationManager.AppSettings["TipoBancoDados"]);

            //switch (tipoBancoDados)
            //{
            //    default:
            //        RegisterDapperNet(container);
            //        break;
            //}
        }

        private static void RegisterDapperNet(IUnityContainer container)
        {
            container.RegisterType<IClienteRepositorio, ClienteDapperRepositorio>(new PerThreadLifetimeManager());
        }
    }
}
