using Theos.Pizzaria.Dominio.Cliente.Interfaces;
using Theos.Pizzaria.Service;
using Unity;
using Unity.Lifetime;

namespace Theos.Pizzaria.IoC
{
    public class RepositoryRegister
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IClienteRepository, ClienteRepository>(new ContainerControlledLifetimeManager());
        }
    }
}

