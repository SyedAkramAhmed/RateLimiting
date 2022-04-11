using Microsoft.AspNetCore.Builder;
using RateLimiting.Middlewares;

namespace RateLimiting.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseRateLimiting(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RateLimitingMiddleware>();
        }
    }
}
