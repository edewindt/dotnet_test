// using MiddlewareExample.MyFirstMiddleware;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

// app.UseStaticFiles();

// app.UseRouting();

// app.UseEndpoints(endpoints => {
//     endpoints.MapGet("name/{name:minlength(2)}", async (context) => {
//        string? name = Convert.ToString(context.Request.RouteValues["name"]);
//         await context.Response.WriteAsync($"{name} is cool");
//         });
//         endpoints.MapGet("items/{id:int?}", async (context) => {
//             if (context.Request.RouteValues.ContainsKey("id"))
//             {
//                    int id = Convert.ToInt32(context.Request.RouteValues["id"]);
//         await context.Response.WriteAsync($"The {id} Item ID");
//             }else
//             {await context.Response.WriteAsync($"The Item ID is not supplied");
                
//             }
    
//         });
//         endpoints.Map("dates/{date:datetime?}", async (context) => {
//             DateTime date = Convert.ToDateTime(context.Request.RouteValues["date"]);
//             await context.Response.WriteAsync($"{date.ToShortDateString()}");
//         });
//     endpoints.MapGet("example", async (context) => await context.Response.WriteAsync("Example"));
//         endpoints.MapPost("example", async (context) => await context.Response.WriteAsync("Example Post"));
//     endpoints.MapGet("example2", async (context) => await context.Response.WriteAsync("Example2"));

//     endpoints.Map("docs/{doc:guid}", async (context) => {
//     Guid doc = Guid.Parse(Convert.ToString(context.Request.RouteValues["doc"])!);
//     await context.Response.WriteAsync($"The GUID for the document is {doc}");
// });
// });

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
