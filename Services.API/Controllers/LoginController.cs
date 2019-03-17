
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
 namespace Services.API.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;
    using Services.API.Core.UserManagement;
    using Services.API.DataModel.DataTransferObjects;
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;

    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private IConfiguration _config;

        private readonly IUserManager _userManager;


        public LoginController(IUserManager userManager, IConfiguration config)
        {
            this._userManager = userManager;
            _config = config;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<string> get()
        {
            return "Server connected";
        }


        [AllowAnonymous]
        [Route("login")]
        [HttpPost]
        [EnableCors("MyPolicy")]
        public IActionResult Login([FromBody]DtoUser login)
        {
            IActionResult response = Unauthorized();
            var user = this._userManager.AuthenticateUser(login);

            if (user != null)
            {
                var tokenString = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }
         
        private string GenerateJSONWebToken(DtoUser userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtIssuerOptions:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(_config["JwtIssuerOptions:Issuer"],
                _config["JwtIssuerOptions:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
