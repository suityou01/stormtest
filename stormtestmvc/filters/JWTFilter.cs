using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace stormtestmvc.filters
{
    public class HasTokenRequirement : IAuthorizationRequirement
    {
        public string Token { get; }

        public HasTokenRequirement(string token)
        {
            Token = token ?? throw new ArgumentNullException(nameof(token));
        }
    }
    public class JWTAuthorizationHandler: AuthorizationHandler<HasTokenRequirement>
    {
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HasTokenRequirement requirement)
    {
        var authFilterCtx = (Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext)context.Resource;
        string authHeader = authFilterCtx.HttpContext.Request.Headers["Authorization"];
        if (authHeader != null && authHeader.Contains("Bearer"))
        {
            var token = authHeader.Replace("Bearer", "");
            context.Succeed(requirement);
            return Task.CompletedTask;
        }
        return Task.CompletedTask;
    }
}    
}



    
