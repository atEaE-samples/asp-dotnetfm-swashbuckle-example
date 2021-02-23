[assembly: WebActivator.PostApplicationStartMethod(typeof(WebAPIExample.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace WebAPIExample.App_Start
{
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using SimpleInjector.Lifestyles;
    using System.Web.Http;
    using WebAPIExample.Domains;

    /// <summary>
    /// Simple injector webapi initializer.
    /// </summary>
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>
        /// Initialize the container and register it as Web API Dependency Resolver.
        /// </summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
            // provider
            container.Register<IUserService, UserService>(Lifestyle.Scoped);
        }
    }
}