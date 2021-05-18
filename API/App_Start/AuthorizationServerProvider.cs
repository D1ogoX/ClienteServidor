using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace API.App_Start
{
    public class AuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            //Validou o utilizador
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);

            using (Models.Exemplo_ESAPEntities _db = new Models.Exemplo_ESAPEntities())
            {
                var _utilizadorEncontrado = _db.tbUtilizador.Find(context.UserName);

                if (_utilizadorEncontrado != null)
                {
                    //Validar utilizador
                    if (_utilizadorEncontrado.password == context.Password)
                    {
                        //Guarda as informações do utilizador registado:
                        identity.AddClaim(new Claim(ClaimTypes.Role, "Role"));
                        identity.AddClaim(new Claim(ClaimTypes.Name, _utilizadorEncontrado.idUtilizador.ToString()));

                        context.Validated(identity);
                    }

                    else
                    {
                        context.SetError("invalid_grant", "Credenciais incorretas");

                        return;
                    }
                }

                else
                {
                    context.SetError("invalid_grant", "Credenciais incorretas");

                    return;
                }
            }
        }
    }
}