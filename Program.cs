var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.MapGet("/anime", () => "Anime Endpoint");


app.Run(async (HttpContext context) => 
{
    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync("<h1>Hello Bro!</h1>");
}
);

app.Run();
