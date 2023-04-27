var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.MapGet("/anime", () => "Anime Endpoint");


app.Run(async (HttpContext context) => 
{
    string path = context.Request.Path;
    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync($"<h1>Hello Bro! {path}</h1>");
}
);

app.Run();
