using AceleraPizza.Dominio.Cliente.Interfaces;
using AceleraPizza.Dominio.Pedido.Interfaces;
using AceleraPizza.Service;
using Unity;
using Unity.Lifetime;

namespace AceleraPizza.InjecaoDependencia
{
    public class ServiceRegister
    {
        public static void Register(IUnityContainer container)
        {
            //Sistema deve criar uma linha toda vez que tem um novo SERVICE
            container.RegisterType<IClienteService, ClienteService>(new PerThreadLifetimeManager());
            container.RegisterType<IPedidoService, PedidoService>(new PerThreadLifetimeManager());
        }
    }
}