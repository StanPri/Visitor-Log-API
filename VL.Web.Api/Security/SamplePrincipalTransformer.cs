﻿using ITSD.BPAS.JwtAuthorizer;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;

namespace VL.Web.Api.Security
{
    public class SamplePrincipalTransformer : IPrincipalTransformer
    {
        public IPrincipal Transform(ClaimsPrincipal principal)
        {
            var roles = principal
                .FindAll(ClaimTypes.Role)
                .Select(x => x.Value)
                .ToArray();

            return new SamplePrincipal(principal.Identity, roles);
        }
    }
}