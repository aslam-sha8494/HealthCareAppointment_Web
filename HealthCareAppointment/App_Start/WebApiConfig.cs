using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HealthCareAppointment
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //for camel notations
            var settings = config.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Formatting.Indented;

            //string origin = "http://localhost:50164/IDGWebClient/";
            //EnableCorsAttribute cors = new EnableCorsAttribute(origin, "*", "GET,POST");
            //config.EnableCors(cors);

            config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
