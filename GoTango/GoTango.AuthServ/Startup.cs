using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ADAS.GoTango.AuthServ.Startup))]

namespace ADAS.GoTango.AuthServ
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
