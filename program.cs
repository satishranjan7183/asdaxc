var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
    "<h1>Hello from ASP.NET Core Web App 🚀</h1>" +
    "<p>Deployed using Azure App Service</p>"
);

app.Run();
