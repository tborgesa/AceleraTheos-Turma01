using SistemaEscola.InjecaoDependencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace SistemaEscola.Swagger
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUnityContainer container = new UnityContainer();
            RegisterForms(container);
            ServiceRegister.Register(container);
            RepositoryRegister.Register(container);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormSistemaEscola>());
        }

        private static void RegisterForms(IUnityContainer container)
        {
            container.RegisterType<FormSistemaEscola>(new ContainerControlledLifetimeManager());
            container.RegisterType<FormContratado>(new ContainerControlledLifetimeManager());
        }
    }
}
