using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

using System.IdentityModel.Tokens;
using System.Threading;
using System.Security.Claims;
using System.Net;
using System.ServiceModel.Security.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using TokenManager = Microsoft.IdentityModel.Tokens;

namespace VL.Web.Api.ValidationHandlers
{
    public class JWTValidationHandler : DelegatingHandler
    {
        //TODO: Move this to config
        private static readonly byte[] SecretBytes = Encoding.UTF8.GetBytes("reactFTW!!!");

        public async Task<HttpResponseMessage> ValidateAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string jwtToken = null;

            // The header is of the form "bearer <accesstoken>", so extract to the right of the whitespace to find the access token.
            var authHeader = request.Headers.Authorization;//.FirstOrDefault(x => x.Key == "Authorization");
            if (authHeader != null) jwtToken = authHeader.Parameter.Trim(); 
            if (string.IsNullOrWhiteSpace(jwtToken)) return new HttpResponseMessage(HttpStatusCode.Unauthorized);

            var secretBytes = Encoding.UTF8.GetBytes("reactFTW!!!");

            //Only do this if signature algorithm is HS256
            //  Okay for now because it is
            if (secretBytes.Length < 64)// && tokenReceived.SignatureAlgorithm == "HS256")
            {
                Array.Resize(ref secretBytes, 64);
            }


            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenManager.TokenValidationParameters
            {
                ValidateLifetime = true,
                //ValidateLifetime = false,
                ValidateAudience = false,
                ValidateIssuer = false,
                IssuerSigningKeys = new[] { new TokenManager.SymmetricSecurityKey(secretBytes) },
            };

            try
            {
                TokenManager.SecurityToken validatedToken = new JwtSecurityToken(jwtToken);

                // Validate token.
                ClaimsPrincipal claimsPrincipal = tokenHandler.ValidateToken(jwtToken, validationParameters, out validatedToken);

                // Set the ClaimsPrincipal on the current thread.
                Thread.CurrentPrincipal = claimsPrincipal;

                // Set the ClaimsPrincipal on HttpContext.Current if the app is running in web hosted environment.
                if (HttpContext.Current != null) HttpContext.Current.User = claimsPrincipal;

                return await base.SendAsync(request, cancellationToken);
            }
            catch (TokenManager.SecurityTokenValidationException ex)
            {
                return new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }
            catch (System.IdentityModel.Tokens.SecurityTokenValidationException)
            {
                return new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        //
        // SendAsync checks that incoming requests have a valid access token, and sets the current user identity using that access token.
        //
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return await ValidateAsync(request, cancellationToken);
        }
    }
}