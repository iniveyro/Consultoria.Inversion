using Consultoria.Inversion.Persistence;
using Consultoria.Inversion.Api;
using Consultoria.Inversion.Common;
using Consultoria.Inversion.Application;
using Consultoria.Inversion.External;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.secret.json", optional: false, reloadOnChange: true);
builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();