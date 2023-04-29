// using MiddlewareExample.MyFirstMiddleware;
var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddTransient<MyFirstMiddleware>();
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints => {
    endpoints.Map("example", async (context) => await context.Response.WriteAsync("Example"));
    endpoints.Map("example2", async (context) => await context.Response.WriteAsync("Example2"));
});

// app.UseWhen(
//     context => context.Request.Query.ContainsKey("name"),
//     app => {
//         app.Use(async (context, next) => {
//             await context.Response.WriteAsync("Hello from UseWhen ");
//             await next();
//         });
//     }
// );
// app.Run(async context => {
//     await context.Response.WriteAsync("Hello from regular middleware");
// });
// app.MapGet("/", () => "Hello World!");

// app.MapGet("/anime", () => "Anime Endpoint");


// app.Run(async (HttpContext context) => 
// {
//     string userAgent;
//     // string path = context.Request.Path;
//     // string method = context.Request.Method;
//     if (context.Request.Headers.ContainsKey("User-Agent"))
//     {
//         userAgent = context.Request.Headers["User-Agent"];

//         context.Response.Headers["Content-Type"] = "text/html";
//     await context.Response.WriteAsync($"<h1>Hello Bro! {userAgent} </h1>");
//     }


// }
// );

// app.Use(async (HttpContext context, RequestDelegate next) => 
// {
//     await context.Response.WriteAsync("First ");
//     await next(context);
// });
// app.UseMyMiddleware();

// app.Use(async (HttpContext context, RequestDelegate next) => 
// {
//     await context.Response.WriteAsync("Second ");
//     await next(context);
// });
// app.Run(async (HttpContext context) => 
// {
//     await context.Response.WriteAsync("Third ");
// });


app.Run();
