using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using PetShop.InjecaoDependencia;

namespace PetShop.Swagger
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //injeção de dependencia aqui
            IUnityContainer container = new UnityContainer();
            RegisterForms(container);
            ServicoRegister.Register(container);
            RepositorioRegister.Register(container);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormPrincipal>());
        }

        private static void RegisterForms(IUnityContainer container)
        {
            container.RegisterType<FormPrincipal>(new ContainerControlledLifetimeManager());
            container.RegisterType<FormCliente>(new ContainerControlledLifetimeManager());
            container.RegisterType<FormAnimal>(new ContainerControlledLifetimeManager());
        }
    }
}
