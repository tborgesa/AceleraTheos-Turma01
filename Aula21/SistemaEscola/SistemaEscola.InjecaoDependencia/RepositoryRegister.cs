using SistemaEscola.Dominio.Funcionario.Interfaces;
using SistemaEscola.Repositorio;
using Unity;
using Unity.Lifetime;
using System.Configuration;


namespace SistemaEscola.InjecaoDependencia
{
    public class RepositoryRegister
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
            container.RegisterType<IContratadoRepositorio, ContratadoArquivoRepositorio>(new PerThreadLifetimeManager());
        }

        private static void RegisterAdoNet(IUnityContainer container)
        {
            container.RegisterType<IContratadoRepositorio, ContratadoAdoNetRepositorio>(new PerThreadLifetimeManager());
        }

        private static void RegisterDapperNet(IUnityContainer container)
        {
            container.RegisterType<IContratadoRepositorio, ContratadoDapperRepositorio>(new PerThreadLifetimeManager());
        }
    }
}
