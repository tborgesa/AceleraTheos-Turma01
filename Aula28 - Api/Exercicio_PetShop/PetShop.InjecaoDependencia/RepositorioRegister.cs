using System;
using System.Configuration;
using PetShop.Dominio.Animais.Interfaces;
using PetShop.Dominio.Pessoas.Interfaces;
using PetShop.Repositorio;
using Unity;
using Unity.Lifetime;

namespace PetShop.InjecaoDependencia
{
    public class RepositorioRegister
    {
        public static void Register(IUnityContainer container)
        {
            var tipoBancoDados = int.Parse(ConfigurationManager.AppSettings["TipoBancoDados"]);

            switch (tipoBancoDados)
            {
                case 1:
                    RegisterArquivo(container);
                    break;
                case 2:
                    RegisterAdoNet(container);
                    break;
                case 3:
                    RegisterDapperNet(container);
                    break;
            }
        }

        private static void RegisterArquivo(IUnityContainer container)
        {
            container.RegisterType<IClienteRepositorio, ClienteRepositorio>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICachorroRepositorio, CachorroRepositorio>(new ContainerControlledLifetimeManager());
            //todo implementar as 3 interfaces de animais.
        }

        private static void RegisterAdoNet(IUnityContainer container)
        {
            container.RegisterType<IClienteRepositorio, ClienteAdoNetRepositorio>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICachorroRepositorio, CachorroAdoNetRepositorio>(new ContainerControlledLifetimeManager());
            //todo implementar as 3 interfaces de animais.
        }

        private static void RegisterDapperNet(IUnityContainer container)
        {
            container.RegisterType<IClienteRepositorio, ClienteDapperRepositorio>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICachorroRepositorio, CachorroDapperRepositorio>(new ContainerControlledLifetimeManager());
            //todo implementar as 3 interfaces de animais.
        }
    }
}
