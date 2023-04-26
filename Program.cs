var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.MapGet("/anime", () => "Anime Endpoint");


app.Run(async (HttpContext context) => 
{
    context.Response.Headers["MyKey"] = "my value";
    await context.Response.WriteAsync("Hello Bro!");
}
);

app.Run();
