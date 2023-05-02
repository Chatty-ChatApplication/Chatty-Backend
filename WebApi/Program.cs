using WebApi.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigServices(builder.Configuration);

var app = builder.Build();
app.Config();
app.Run();