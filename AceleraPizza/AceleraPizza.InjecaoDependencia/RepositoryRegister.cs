using AceleraPizza.Dominio.Cliente.Interfaces;
using AceleraPizza.Dominio.Pedido.Interfaces;
using AceleraPizza.Dominio.PedidoIngrediente.Interfaces;
using AceleraPizza.Repositorio;
using Unity;
using Unity.Lifetime;

namespace AceleraPizza.InjecaoDependencia
{
    public class RepositoryRegister
    {
        public static void Register(IUnityContainer container)
        {
            RegisterDapperNet(container);
            //var tipoBancoDados = int.Parse(ConfigurationManager.AppSettings["TipoBancoDados"]);

            //switch (tipoBancoDados)
            //{
            //    default:
            //        RegisterDapperNet(container);
            //        break;
            //}
        }

        private static void RegisterDapperNet(IUnityContainer container)
        {
            //CADA SERVICE INSERIR MAIS UMA LINHA
            container.RegisterType<IClienteRepositorio, ClienteDapperRepositorio>(new PerThreadLifetimeManager());
            container.RegisterType<IPedidoRepositorio, PedidoDapperRepositorio>(new PerThreadLifetimeManager());
            container.RegisterType<IPedidoIngredienteRepositorio, PedidoIngredienteDapperRepositorio>(new PerThreadLifetimeManager());
        }
    }
}
