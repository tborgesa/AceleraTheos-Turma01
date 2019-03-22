using System;
using System.Configuration;
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
            }
        }

        private static void RegisterArquivo(IUnityContainer container)
        {
            container.RegisterType<IClienteRepositorio, ClienteRepositorio>(new ContainerControlledLifetimeManager());
        }

        private static void RegisterAdoNet(IUnityContainer container)
        {
            container.RegisterType<IClienteRepositorio, ClienteAdoNetRepositorio>(new ContainerControlledLifetimeManager());
        }

        private static void RegisterDapperNet(IUnityContainer container)
        {
            container.RegisterType<IClienteRepositorio, ClienteDapperRepositorio>(new ContainerControlledLifetimeManager());
        }
    }
}
