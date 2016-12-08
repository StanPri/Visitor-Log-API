using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace VL.Web.Api.Filters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class EnableBpasCors : Attribute, ICorsPolicyProvider
    {
        private CorsPolicy _policy;

        public EnableBpasCors()
        {
            //Create CORS Policy
            _policy = new CorsPolicy 
            { 
                AllowAnyMethod = true,
                AllowAnyHeader = true,
            };

            //Add Allowed Origins
            var origins = ConfigurationManager.AppSettings[""].Split(';');
            foreach (var orig in origins)
                _policy.Origins.Add(orig);
        }

        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_policy);
        }
    }
}