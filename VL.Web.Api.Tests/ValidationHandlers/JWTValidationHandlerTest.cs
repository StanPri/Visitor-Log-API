using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VL.Web.Api.ValidationHandlers;
using Xunit;

namespace VL.Web.Api.Tests.ValidationHandlers
{
    public class JWTValidationHandlerTest
    {
        private const string JWTTokenText = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJURENcXEhlbnJ5LlJvZHJpZ3VleiIsIkNOIjoiVXNlciIsIkNUUyI6IlVzZXItY3drIiwiaWF0IjoxNDgyNDQ1MTIxLCJleHAiOjE0ODI0NDg3MjF9.6ENR8bE9IViZUri28k_lutZpySxnu-wEgXJ9C1N1AsA";
        private const string JWTAuthorizationHeaderText = "Bearer " + JWTTokenText;

        [Fact]
        public void WhenGivenJWT_AssertResult()
        {
            var handler = new JWTValidationHandler();

            var request = new HttpRequestMessage();
            request.Headers.Add("Authorization", JWTAuthorizationHeaderText);


            var result = handler.ValidateAsync(request, new CancellationToken()).Result;

        }
    }
}
