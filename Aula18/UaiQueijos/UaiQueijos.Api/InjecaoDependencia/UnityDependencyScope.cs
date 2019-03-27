using System;
using System.Collections.Generic;
using System.Web.Http.Controllers;
using System.Web.Http.Dependencies;
using Unity;

namespace UaiQueijos.Api.InjecaoDependencia
{
    public class UnityDependencyScope : IDependencyScope
    {
        protected IUnityContainer Container { get; }

        public UnityDependencyScope(IUnityContainer container)
        {
            Container = container;
        }

        public object GetService(Type serviceType)
        {
            if (typeof(IHttpController).IsAssignableFrom(serviceType))
            {
                return Container.Resolve(serviceType);
            }

            try
            {
                return Container.Resolve(serviceType);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Container.ResolveAll(serviceType);
        }

        public void Dispose()
        {
            Container.Dispose();
        }
    }

    public sealed class UnityDependencyResolver : UnityDependencyScope, IDependencyResolver
    {
        public UnityDependencyResolver(IUnityContainer container)
            : base(container)
        {
        }

        public IDependencyScope BeginScope()
        {
            var childContainer = Container.CreateChildContainer();

            return new UnityDependencyScope(childContainer);
        }
    }
}