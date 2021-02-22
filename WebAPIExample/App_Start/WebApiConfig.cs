using System.Web.Http;

namespace WebAPIExample
{
    /// <summary>
    /// WebAPI configuration.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// register my settings.
        /// </summary>
        /// <param name="config">configuration.</param>
        public static void Register(HttpConfiguration config)
        {
            // WebAPI configuration and services.
            

            // WebAPI routes.
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
