using Consultoria.Inversion.Persistence;
using Consultoria.Inversion.Api;
using Consultoria.Inversion.Common;
using Consultoria.Inversion.Application;
using Consultoria.Inversion.External;
using Azure.Identity;
using System.Runtime.Intrinsics;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Configuration.AddJsonFile("appsettings.secret.json", optional: false, reloadOnChange: true);
/*
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
*/
builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(options => 
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json","v1");
    options.RoutePrefix = string.Empty;
});
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();