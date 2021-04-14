using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.AuthenticationModule;
using BusinessLayer.DTOModel.BusinessModel;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;
        private readonly IConfiguration _config;
        public AuthController(IAuthService service, IConfiguration config)
        {
            _service = service;
            _config = config;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserModel user)
        {
            user.Username = user.Username.ToLower();
            if (await _service.UserExists(user.Username))
                return BadRequest("Username alredy exists");
            var userToCreate = new User
            {
                Username = user.Username
            };
            var createdUser = await _service.Register(userToCreate, user.Password);
            return StatusCode(201);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserForLoginModel user)
        {
            var userFromDatabase = await _service.Login(user.Username, user.Password);
            if (userFromDatabase == null)
                return Unauthorized();
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userFromDatabase.UserId.ToString()),
                new Claim(ClaimTypes.Name, userFromDatabase.Username)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };
            var tokenHandeler = new JwtSecurityTokenHandler();
            var token = tokenHandeler.CreateToken(tokenDescription);
            return Ok(new
            {
                token = tokenHandeler.WriteToken(token)
            });
        }
    }
}
