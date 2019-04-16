using Theos.Pizzaria.Dominio.Cliente.Interfaces;
using Theos.Pizzaria.Service;
using Unity;
using Unity.Lifetime;

namespace Theos.Pizzaria.IoC
{
    public class ServiceRegister
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IClienteService, ClienteService>(new ContainerControlledLifetimeManager());
        }
    }
}
