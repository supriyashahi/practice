var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//Use method is used to add a middleware to the request pipeline
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello from 1st Middleware\n");
    await next();
});
//next delegate is used to call the next middleware in the pipeline
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello from 2nd Middleware\n");
    await next();
});
//Run always terminates the request pipeline
//Run method is used to add a terminal middleware to the request pipeline
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello from last Middleware\n");
});

app.Run();
