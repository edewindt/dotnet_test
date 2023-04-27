namespace MiddlewareExample.MyFirstMiddleware
{
    public class MyFirstMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("My First Middleware");
            await next(context);
        }
    }
}