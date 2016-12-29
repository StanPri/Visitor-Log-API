using ITSD.BPAS.JwtAuthorizer;
using System.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;
using VL.Web.Api.Security;

namespace VL.Web.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Register CacheCow
            var cacheCow = new CacheCow.Server.CachingHandler(config, "");
            config.MessageHandlers.Add(cacheCow);            
            
            //Enable CORS
            //http://www.asp.net/web-api/overview/security/enabling-cross-origin-requests-in-web-api

            //var cors = new EnableCorsAttribute(ConfigurationManager.AppSettings["CORSSites"].ToString(), "*", "*");
            //cors.SupportsCredentials = true; //the HTTP response will include an 'Access-Control-Allow-Credentials' header
            //config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            var tokenBuilder = new SecurityTokenBuilder();
            var configReader = new ConfigurationReader();

            //var jwtHandlerCert = new JwtAuthenticationMessageHandler
            //{
            //    AllowedAudience = configReader.AllowedAudience,
            //    AllowedAudiences = configReader.AllowedAudiences,
            //    Issuer = configReader.Issuer,
            //    SigningToken = tokenBuilder.CreateFromCertificate(configReader.SubjectCertificateName),
            //    PrincipalTransformer = new SamplePrincipalTransformer()
            //};

            var jwtHandlerSharedKey = new JwtAuthenticationMessageHandler
            {
                AllowedAudience = configReader.AllowedAudience,
                Issuer = configReader.Issuer,
                SigningToken = tokenBuilder.CreateFromKey(configReader.SymmetricKey),
                PrincipalTransformer = new SamplePrincipalTransformer(),
                CookieNameToCheckForToken = configReader.CookieNameToCheckForToken
            };

            //config.MessageHandlers.Add(jwtHandlerCert);
            config.MessageHandlers.Add(jwtHandlerSharedKey);






        }
    }
}
