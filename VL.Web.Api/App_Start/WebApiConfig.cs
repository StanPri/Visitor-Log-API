using System.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;

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
        }
    }
}
