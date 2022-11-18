using AutenticationService.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;



namespace AuthenticationService.Infrastructure
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _appSettings;
        public JwtMiddleware(RequestDelegate next, AppSettings settings)
        {
            _next = next;
            _appSettings = settings;
        }
        public async Task Invoke(HttpContext context)
        {
            //HTTPHeader [Authorization - Bearer <<token>>]
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (token is not null)
            {
                try
                {
                    JwtSecurityTokenHandler tokenHandler = new();
                    var key = System.Text.Encoding.UTF8.GetBytes(_appSettings.AppSecretKey);
                    tokenHandler.ValidateToken(token,
                    new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ClockSkew = System.TimeSpan.Zero
                    }, out SecurityToken validatedToken);
                    var jwtToken = validatedToken as JwtSecurityToken;
                    var userName = jwtToken.Claims.First(c => c.Type == "Username").Value;
                    var fullName = jwtToken.Claims.First(c => c.Type == "FullName").Value;
                    context.Items["Username"] = userName;
                    context.Items["FullName"] = fullName;
                }
                catch (System.Exception ex) { throw; }
            }
            await _next(context);
        }

    }
}