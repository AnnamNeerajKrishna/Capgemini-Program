using AutenticationService.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NorthwindDataAccess;
using NorthwindEntities;
using System.IdentityModel.Tokens.Jwt;
namespace AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UsersDAO _userDB;
        private AppSettings appSettings;
        public AccountController(UsersDAO dao, AppSettings settings)
        {
            _userDB = dao;
            appSettings = settings;
        }
        [HttpPost]
        public ActionResult<AuthenticationResponse> Authenticate(User model)
        {
            var user = _userDB.Authenticate(model);
            if (user == null)
            {
                return BadRequest(new { message = "Invalid credentials. Username/password is wrong" });
            }//Generate the JWT Token
            JwtSecurityTokenHandler tokenHandler = new();
            var key = System.Text.Encoding.UTF8.GetBytes(appSettings.AppSecretKey);
            SecurityTokenDescriptor tokenDescriptor = new()
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
            {
                new System.Security.Claims.Claim("Username", user.Username),
                new System.Security.Claims.Claim("FullName", user.FullName)
            }),
                Expires = System.DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(
            key: new SymmetricSecurityKey(key),
            algorithm: SecurityAlgorithms.HmacSha256Signature
            )
            };
            var pretoken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(pretoken);
            var authResponse = new AuthenticationResponse(user, token);
            return authResponse;
        }
    }
}
