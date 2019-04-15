using AceleraPizza.Dominio.Cliente.Interfaces;
using AceleraPizza.Service;
using Unity;
using Unity.Lifetime;

namespace AceleraPizza.InjecaoDependencia
{
    public class ServiceRegister
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IClienteService, ClienteService>(new PerThreadLifetimeManager());
        }
    }
}
