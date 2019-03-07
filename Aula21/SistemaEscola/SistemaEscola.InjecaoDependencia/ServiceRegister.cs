using SistemaEscola.Dominio.Contratado.Interfacecs;
using SistemaEscola.Service;
using Unity;
using Unity.Lifetime;

namespace SistemaEscola.InjecaoDependencia
{
    public class ServiceRegister
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IContratadoService, ContratadoService>(new PerThreadLifetimeManager());
        }
    }
}
