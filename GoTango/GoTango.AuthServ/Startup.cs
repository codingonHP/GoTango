using System;
using System.Security.Cryptography.X509Certificates;
using ADAS.GoTango.AuthServ.ConfigAsm.Config;
using Microsoft.Owin;
using Owin;
using Thinktecture.IdentityServer.Core.Configuration;
using Thinktecture.IdentityServer.Core.Models;

[assembly: OwinStartup(typeof(ADAS.GoTango.AuthServ.Startup))]

namespace ADAS.GoTango.AuthServ
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/identity", idsrvApp => idsrvApp.UseIdentityServer(new IdentityServerOptions
            {
                SiteName = "Embedded IdentityServer",
                SigningCertificate = LoadCertificate(),
                Factory = InMemoryFactory.Create( users: Users.GetInMemoryUsers(),
                                                  clients: Clients.GetAllClients(),
                                                  scopes: StandardScopes.All)
            }));


        }

        private X509Certificate2 LoadCertificate()
        {
            return new X509Certificate2( string.Format(@"{0}\certificates\idsrv3test.pfx", AppDomain.CurrentDomain.BaseDirectory), "idsrv3test" );
        }
    }
}
