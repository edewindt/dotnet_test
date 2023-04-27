var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.MapGet("/anime", () => "Anime Endpoint");


app.Run(async (HttpContext context) => 
{
    string name;
    // string path = context.Request.Path;
    // string method = context.Request.Method;
    if (context.Request.Query.ContainsKey("name"))
    {
        name = context.Request.Query["name"];

        context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync($"<h1>Hello Bro! {name} </h1>");
    }
    
    
}
);

app.Run();
