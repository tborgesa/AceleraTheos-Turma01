using PetShop.Dominio.Pessoas.Interfaces;
using PetShop.Service;
using PetShop.Repositorio;
using Unity;
using Unity.Lifetime;

namespace PetShop.InjecaoDependencia
{
    public class ServicoRegister
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IClienteService, ClienteService>(new ContainerControlledLifetimeManager());
        }
    }
}
