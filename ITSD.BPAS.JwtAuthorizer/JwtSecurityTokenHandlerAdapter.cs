using System.IdentityModel.Tokens;
using System.Security.Claims;

namespace ITSD.BPAS.JwtAuthorizer
{
    public class JwtSecurityTokenHandlerAdapter : IJwtSecurityTokenHandler
    {
        private readonly JwtSecurityTokenHandler _securityTokenHandler;

        public JwtSecurityTokenHandlerAdapter()
        {
            _securityTokenHandler = new JwtSecurityTokenHandler();
        }

        public ClaimsPrincipal ValidateToken(IJwtSecurityToken securityToken,
            TokenValidationParameters validationParameters)
        {
            SecurityToken validatedToken = null;
            return _securityTokenHandler.ValidateToken(securityToken.RawData, validationParameters, out validatedToken);
        }
    }
}