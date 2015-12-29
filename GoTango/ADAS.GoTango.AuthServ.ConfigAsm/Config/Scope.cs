using System.Collections.Generic;
using Thinktecture.IdentityServer.Core.Models;

namespace ADAS.GoTango.AuthServ.ConfigAsm.Config
{
    public static class Scopes
    {
        public static List<Scope> GetScopes()
        {
            return new List<Scope>
            {
                new Scope
                {
                    Name = "GoTango",
                    Description = "sample application for gotango application",
                    DisplayName = "GoTango",
                    Type = ScopeType.Resource

                }
            };
        }
    }
}
