using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace VL.Web.Api.Filters
{
    public class WinAuthAttribute : AuthorizeAttribute
    {
        public string RequiredRole { get; set; }

        //[Authorize]
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            BuildCorsResponse();
            // Contains the current users's identity, needed to query AD.
            //var identity = HttpContext.Current.Request.LogonUserIdentity;
            var groups = GetGroups();

            switch (RequiredRole)
            {
                // Handles all functions that require "Identity Only"
                case "":
                case null: return true;

                // Sample snippet on how to check if user has rights using AD
                case "Admins":
                    {
                        if ((from x in groups
                             where
                                 x == @"ITSDLAB\SharePoint Admins" |
                                 x == @"ITSDLAB\SP Developers"
                             select x).Count() > 0)
                            return true;

                        return NoRights();
                    }
                case "LocalDevelopers":
                    {
                        if ((from x in groups
                             where
                                 x == @"ITSDLABSP13-3\SP Developers"
                             select x).Count() > 0)
                            return true;

                        return NoRights();
                    }
                // if the role is not identited, send a "No Rights" response.
                default:
                    if ((from x in groups
                         where
                             x == RequiredRole
                         select x).Count() > 0)
                        return true;

                    return NoRights();
            }
        }

        /// <summary>
        /// Authentication handler - Returns as a 500 error, as the user has an identity; but no rights.
        /// </summary>
        /// <returns></returns>
        protected bool NoRights()
        {
            throw new Exception("User has no rights to the given role");
        }

        /// <summary>
        /// Gets Active Directory groups for the current user Identity.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetGroups()
        {
            List<string> groups = new List<string>();
            var httpc = HttpContext.Current;

            foreach (IdentityReference group in HttpContext.Current.Request.LogonUserIdentity.Groups)
            {
                var g = group.Translate(typeof(NTAccount)).ToString();
                groups.Add(g);
            }

            return groups;
        }


        /// <summary>
        /// Converts any wildcard string to a Regular Expression. This can then be used to identify if
        /// a string matches the wildcard query using the regex .IsMatch method.
        /// </summary>
        /// <param name="pattern">Input wildcard string</param>        
        public static Regex WildcardToRegex(string pattern)
        {
            return new Regex("^" + Regex.Escape(pattern)
                    .Replace("\\*", ".*")
                    .Replace("\\?", ".") + "$");
        }
        /// <summary>
        /// Prepares HttpResponse for cross-domain access and credentials pass-through.
        /// </summary>
        protected static void BuildCorsResponse(string allowMethods = "GET, POST, PUT, DELETE, OPTIONS")
        {
            var Request = HttpContext.Current.Request;
            var Response = HttpContext.Current.Response;
            var domain = Request.UrlReferrer.GetLeftPart(UriPartial.Authority);
            var wildcards = ConfigurationManager.AppSettings["Cross-Domain-Wildcards"].Split(';');
            foreach (var card in wildcards)
            {
                if (card.Trim() != "")
                {
                    var pattr = WildcardToRegex(card.Trim());
                    if (pattr.IsMatch(domain))
                    {
                        // Header Config, automatically allows requestor domain.                    
                        Response.Headers.Remove("Access-Control-Allow-Origin");
                        // The domain has matched the request domains, and is now 
                        // ready to execute a function. the domain is fed as the current requestors domain.
                        Response.AddHeader("Access-Control-Allow-Origin", domain);

                        Response.Headers.Remove("Access-Control-Allow-Credentials");
                        Response.AddHeader("Access-Control-Allow-Credentials", "true");

                        Response.Headers.Remove("Access-Control-Allow-Methods");
                        Response.AddHeader("Access-Control-Allow-Methods", allowMethods);
                        return;
                    }
                }
            }
            throw new Exception();
        }
    }
}