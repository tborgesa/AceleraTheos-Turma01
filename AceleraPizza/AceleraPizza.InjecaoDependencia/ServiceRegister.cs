using AceleraPizza.Dominio.Cliente.Interfaces;
using AceleraPizza.Dominio.Ingrediente.Interfaces;
using AceleraPizza.Dominio.Pedido.Interfaces;
using AceleraPizza.Dominio.PedidoIngrediente.Interfaces;
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
            container.RegisterType<IPedidoIngredienteService, PedidoIngredienteService>(new PerThreadLifetimeManager());
            container.RegisterType<IIngredienteService, IngredienteService>(new PerThreadLifetimeManager());
        }
    }
}