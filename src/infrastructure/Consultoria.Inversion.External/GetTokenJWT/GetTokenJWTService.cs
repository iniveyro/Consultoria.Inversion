using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Consultoria.Inversion.Application.External.GetTokenJWT;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Consultoria.Inversion.External.GetTokenJWT
{
    public class GetTokenJWTService : IGetTokenJWTService
    {
        private readonly IConfiguration _configuration;
        public GetTokenJWTService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Execute (string id)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            string key = _configuration["secret-key-jwt"];
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var tokenDescriptor = new SecurityTokenDescriptor // Corregido: eliminados los corchetes []
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, id)
                }),
                Expires = DateTime.UtcNow.AddMinutes(2),
                SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256Signature),
                Issuer = _configuration["issure-jwt"], 
                Audience = _configuration["audience-jwt"]
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString; 
        }
    }
}