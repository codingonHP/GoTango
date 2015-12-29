using System.Collections.Generic;
using System.Security.Claims;
using Thinktecture.IdentityServer.Core;
using Thinktecture.IdentityServer.Core.Services.InMemory;

namespace ADAS.GoTango.AuthServ.ConfigAsm.Config
{
    public static class Users
    {
        public static List<InMemoryUser> GetInMemoryUsers()
        {
            return new List<InMemoryUser>
            {
                new InMemoryUser
                {
                    Username = "vishal.anand2@hpe.com",
                    Password = "test@123",
                    Subject = "C6500071-EC4D-407D-A4CF-CB4315C55303",
                    Claims = new[] {
                        new Claim(Constants.ClaimTypes.GivenName, "Vishal"),
                        new Claim(Constants.ClaimTypes.FamilyName, "Anand")
                    }
                },
                new InMemoryUser
                {
                    Username = "alisha.anand2@hpe.com",
                    Password = "test@1234",
                    Subject = "BE88055F-CB5C-4F70-B548-0C525FD06631",
                    Claims = new[] {
                        new Claim(Constants.ClaimTypes.GivenName, "Alisha"),
                        new Claim(Constants.ClaimTypes.FamilyName, "Anand")
                    }
                }
            };
        }
    }
}
