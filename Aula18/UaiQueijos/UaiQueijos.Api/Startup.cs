using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using System.Globalization;
using System.Web.Http;
using UaiQueijos.Api.Config;

namespace UaiQueijos.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            //app.UseCors(CorsOptions.AllowAll);
            ConfigureFormatters(configuration);

            configuration.MapHttpAttributeRoutes(new CustomDirectRouteProvider());
            //configuration.Routes.MapHttpRoute("DefaultHttpRoute", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            app.UseWebApi(configuration);
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