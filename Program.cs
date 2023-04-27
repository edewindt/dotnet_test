var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

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

app.Use(async (HttpContext context, RequestDelegate next) => 
{
    await context.Response.WriteAsync("First");
    await next(context);
});
app.Run(async (HttpContext context) => 
{
    await context.Response.WriteAsync("Second");
});

app.Run();
