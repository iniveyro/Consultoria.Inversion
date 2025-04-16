using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Storage;
using Consultoria.Inversion.Persistence;
using Consultoria.Inversion.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Consultoria.Inversion.Application.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseService>(options => 
    options.UseSqlServer(builder.Configuration["SQLConnection"])
);

builder.Services.AddScoped<IDatabaseService,DatabaseService>();

var app = builder.Build();

app.Run();