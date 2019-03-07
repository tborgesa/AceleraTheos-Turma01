using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UaiQueijos.InjecaoDependencia;
using Unity;
using Unity.Lifetime;

namespace UaiQueijos.Swagger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
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
            container.RegisterType<FormFornecedor>(new ContainerControlledLifetimeManager());
        }
    }
}
