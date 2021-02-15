﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using System.Globalization;
using System.Web.Http;
using PetShop.Api.Config;
using Swashbuckle.Application;
using Unity;
using PetShop.InjecaoDependencia;
using PetShop.Api.InjecaoDependencia;

namespace PetShop.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            ConfigureFormatters(configuration);
            configuration.MapHttpAttributeRoutes(new CustomDirectRouteProvider());
            app.UseWebApi(configuration);
            configuration.EnsureInitialized();

            configuration.EnableSwagger(c =>
           {
               c.SingleApiVersion("v1", "PetShop");
           })
           .EnableSwaggerUi(c =>
          {
              c.DocumentTitle("PetShop");
          });

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