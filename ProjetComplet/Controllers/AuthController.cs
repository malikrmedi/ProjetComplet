using BCrypt.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetComplet.Models;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace ProjetComplet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();
        private readonly IConfiguration _configuration;


        public AuthController(IConfiguration configuration)
        {
            _configuration= configuration;
            
        }

        [HttpPost("register")]
        public ActionResult<User> Register(UserDTO userDTO)
        {
            string passwordCrypted = BCrypt.Net.BCrypt.HashPassword(userDTO.password);

            user.username = userDTO.username;
            user.passwordCrypted = passwordCrypted;

            return Ok(user);

        }


        [HttpPost("login")]
        public ActionResult<User> login(UserDTO userDTO)
        {
            if (user.username != userDTO.username)
            {
                return BadRequest("does not exist");
            }

            if (!BCrypt.Net.BCrypt.Verify(userDTO.password,user.passwordCrypted))
            {
                return BadRequest("wrong password");
            }


            string Token = createToken(user);

            return Ok(Token);

        }


        private string createToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.username)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value!));


            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;





        }




    }
}
