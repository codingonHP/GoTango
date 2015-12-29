using System.Web.Http;
using ADAS.GoTango.Helpers;
using Microsoft.Owin;
using Owin;
using Thinktecture.IdentityServer.AccessTokenValidation;

[assembly: OwinStartup(typeof(ADAS.GoTango.WebApiService.Startup))]

namespace ADAS.GoTango.WebApiService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = GoTangoConstants.AuthorityUrl,
                RequiredScopes = new[] { "sampleApi" }
            });

            // web api configuration
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);
        }
    }
}
