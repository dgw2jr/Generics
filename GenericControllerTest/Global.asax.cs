using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;

namespace WebApiService
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            ConfigureDI(GlobalConfiguration.Configuration);
        }

        private void ConfigureDI(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyModules(Assembly.Load("Infrastructure.Data"));

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}