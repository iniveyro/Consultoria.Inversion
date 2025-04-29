using System.Text;
using Consultoria.Inversion.Application.External.GetTokenJWT;
using Consultoria.Inversion.External.GetTokenJWT;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.AspNetCore.Extensions;

namespace Consultoria.Inversion.External
{
    public static class DependecyInyeccionService
    {
        public static IServiceCollection AddExternal(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IGetTokenJWTService, GetTokenJWTService>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
            {
                var secretKey = configuration["secret-key-jwt"];
                if (string.IsNullOrEmpty(secretKey))
                {
                    throw new InvalidOperationException("JWT SecretKey no está configurado.");
                }
                
                option.TokenValidationParameters = new TokenValidationParameters{
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                    ValidIssuer = configuration["issure-jwt"], 
                    ValidAudience = configuration["audience-jwt"]
                };
            });
            services.AddApplicationInsightsTelemetry(new ApplicationInsightsServiceOptions
            {
                ConnectionString = configuration["ApplicationInsightsConnectionString"]
            });
            return services;
        }
    }
}