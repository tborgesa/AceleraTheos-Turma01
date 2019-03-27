using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using System.Globalization;
using System.Web.Http;
using UaiQueijos.Api.Config;
using Swashbuckle.Application;
using Unity;
using UaiQueijos.InjecaoDependencia;
using UaiQueijos.Api.InjecaoDependencia;

namespace UaiQueijos.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            ConfigureFormatters(configuration);
            configuration.MapHttpAttributeRoutes(new CustomDirectRouteProvider());
            app.UseWebApi(configuration);

            configuration.EnableSwagger(c =>
            { c.SingleApiVersion("v1", "UaiQueijos"); })
            .EnableSwaggerUi(c => c.DocumentTitle("UaiQueijos"));

            IUnityContainer container = new UnityContainer();
            ServicoRegister.Register(container);
            RepositorioRegister.Register(container);
            configuration.DependencyResolver = new UnityDependencyResolver(container);

            configuration.EnsureInitialized();
        }

        private void ConfigureFormatters(HttpConfiguration configuration)
        {
            configuration.Formatters.Remove(configuration.Formatters.XmlFormatter);

            configuration.Formatters.JsonFormatter.SerializerSettings.Formatting = Formatting.Indented;
            configuration.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            configuration.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            configuration.Formatters.JsonFormatter.SerializerSettings.DateFormatString = "dd/MM/yyyy HH:mm:ss";
            configuration.Formatters.JsonFormatter.SerializerSettings.Culture = CultureInfo.CurrentCulture;
        }
    }
}