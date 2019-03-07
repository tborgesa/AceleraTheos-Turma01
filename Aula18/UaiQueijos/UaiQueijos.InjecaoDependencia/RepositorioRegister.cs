using System.Configuration;
using UaiQueijos.Dominio.Fornecedor.Interfaces;
using UaiQueijos.Repositorio;
using Unity;
using Unity.Lifetime;

namespace UaiQueijos.InjecaoDependencia
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
                default:
                    RegisterArquivo(container);
                    break;
            }
        }

        private static void RegisterArquivo(IUnityContainer container)
        {
            container.RegisterType<IFornecedorRepositorio, FornecedorArquivoRepositorio>(new ContainerControlledLifetimeManager());
        }

        private static void RegisterAdoNet(IUnityContainer container)
        {
            container.RegisterType<IFornecedorRepositorio, FornecedorAdoNetRepositorio>(new ContainerControlledLifetimeManager());
        }

        private static void RegisterDapperNet(IUnityContainer container)
        {
            container.RegisterType<IFornecedorRepositorio, FornecedorDapperRepositorio>(new ContainerControlledLifetimeManager());
        }
    }
}
