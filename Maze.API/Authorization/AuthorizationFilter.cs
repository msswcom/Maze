using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Maze.API.Authorization
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        readonly string Authorization;

        public AuthorizationFilter(IConfiguration configuration)
        {
            var authorization = configuration[nameof(Authorization)];

            ArgumentException.ThrowIfNullOrEmpty(authorization);

            Authorization = authorization;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var authorization = context.HttpContext.Request.Headers.Authorization.ToString()
                .Replace(AuthorizationScheme.Value, "").Trim();

            if (authorization != Authorization)
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
