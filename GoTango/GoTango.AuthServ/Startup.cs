using System;
using System.Security.Cryptography.X509Certificates;
using ADAS.GoTango.AuthServ.ConfigAsm.Config;
using ADAS.GoTango.Helpers;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
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

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies"
            });

            app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
            {
                Authority = GoTangoConstants.AuthorityUrl,
                ClientId = "mvc",
                RedirectUri = GoTangoConstants.RedirectUri,
                ResponseType = "id_token",
                SignInAsAuthenticationType = "Cookies"
            });



        }

        private X509Certificate2 LoadCertificate()
        {
            return new X509Certificate2( string.Format(@"{0}\certificates\idsrv3test.pfx", AppDomain.CurrentDomain.BaseDirectory), "idsrv3test" );
        }
    }
}
