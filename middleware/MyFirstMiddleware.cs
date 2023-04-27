namespace MiddlewareExample.MyFirstMiddleware
{
    public class MyFirstMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Middelware Starts ");
            await next(context);
            await context.Response.WriteAsync("Middlware Ends ");
        }
    }

    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder app) 
        {
                return app.UseMiddleware<MyFirstMiddleware>();
        }
    }
}