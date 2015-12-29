using System.Collections.Generic;
using Thinktecture.IdentityServer.Core.Models;

namespace ADAS.GoTango.AuthServ.ConfigAsm.Config
{
    public static class Clients
    {
        public static IEnumerable<Client> GetAllClients()
        {
            return new[]
        {
            new Client 
            {
                Enabled = true,
                ClientName = "MVC Client",
                ClientId = "mvc",
                Flow = Flows.Implicit,

                RedirectUris = new List<string>
                {
                    "https://localhost:44300/"
                }
            }
        };
        }
    }
}
