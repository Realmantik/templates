using log4net;
using log4net.Config;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System.Configuration;
using System.Web.Http;

namespace WebApi.Template
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ILog log = LogManager.GetLogger("WebApi.Template.Log");
            XmlConfigurator.Configure();

            string connectionString = ConfigurationManager.ConnectionStrings["ProjectConnectionString"].ConnectionString;
            
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
           
            container.Register<ILog>(() => log, Lifestyle.Scoped);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}
