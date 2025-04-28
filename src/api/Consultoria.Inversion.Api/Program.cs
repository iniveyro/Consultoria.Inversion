using Consultoria.Inversion.Persistence;
using Consultoria.Inversion.Api;
using Consultoria.Inversion.Common;
using Consultoria.Inversion.Application;
using Consultoria.Inversion.External;
using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);


builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

builder.Services.AddControllers();

if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")=="local")
{
    //Forma local
    builder.Configuration.AddJsonFile("appsettings.secret.json", optional: false, reloadOnChange: true);
}
else
{
    var keyvaultURL = builder.Configuration["keyVaultURL"] ?? string.Empty;
    builder.Configuration.AddAzureKeyVault(new Uri(keyvaultURL), new DefaultAzureCredential());    
}

var app = builder.Build();
app.MapControllers();
app.Run();