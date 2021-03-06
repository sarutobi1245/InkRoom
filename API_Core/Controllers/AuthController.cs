using System.Threading.Tasks;
using INK_API.DTO;
using INK_API.Data;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System;
using System.IdentityModel.Tokens.Jwt;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace INK_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        public AuthController(IAuthRepository repo, IConfiguration config, IMapper mapper)
        {
            _mapper = mapper;
            _config = config;
            _repo = repo;
        }

        private void SetRefreshTokenInCookie(string refreshToken)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(10),
            };
            Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var userFromRepo = await _repo.Login(userForLoginDto.Username, userForLoginDto.Password) ;
            if (userFromRepo == null)
              return Unauthorized() ;
            var claims = new[]
            {
              new Claim(ClaimTypes.NameIdentifier, userFromRepo.ID.ToString()),
              new Claim(ClaimTypes.Name, userFromRepo.Username)
            } ;

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value)) ;

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature) ;

            var tokenDescriptor = new SecurityTokenDescriptor
            {
              Subject = new ClaimsIdentity(claims),
              Expires = DateTime.Now.AddDays(1),
              SigningCredentials = creds
            } ;
            
            var tokenHandler = new JwtSecurityTokenHandler() ;
            var token = tokenHandler.CreateToken(tokenDescriptor) ;
            var user = _mapper.Map<UserForDetailDto>(userFromRepo) ;
            SetRefreshTokenInCookie(tokenHandler.WriteToken(token)) ;
            return Ok(new
            {
              token = tokenHandler.WriteToken(token),
              user
            }) ;
        }
    }
}