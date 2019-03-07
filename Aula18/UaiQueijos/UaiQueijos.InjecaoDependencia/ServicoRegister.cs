using UaiQueijos.Dominio.Fornecedor.Interfaces;
using UaiQueijos.Repositorio;
using UaiQueijos.Service;
using Unity;
using Unity.Lifetime;

namespace UaiQueijos.InjecaoDependencia
{
    public class ServicoRegister
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IFornecedorService, FornecedorService>(new ContainerControlledLifetimeManager());
        }
    }
}
