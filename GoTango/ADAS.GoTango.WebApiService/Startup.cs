using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ADAS.GoTango.WebApiService.Startup))]

namespace ADAS.GoTango.WebApiService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // web api configuration
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);
        }
    }
}
