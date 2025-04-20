using Consultoria.Inversion.Persistence;
using Consultoria.Inversion.Api;
using Consultoria.Inversion.Common;
using Consultoria.Inversion.Application;
using Consultoria.Inversion.External;
using Consultoria.Inversion.Application.Database.User.Commands.CreateUser;
using Consultoria.Inversion.Application.Database.User.Commands.UpdateUser;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.secret.json", optional: false, reloadOnChange: true);
builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

var app = builder.Build();

app.Run();