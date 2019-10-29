using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Restauranti.Dto.Authentication;
using Restauranti.Entities.Models.Authentication;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Restauranti.Api.Controllers.Authentication
{
    [Route("api/[controller]")]
    public class UserController : BaseController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        private readonly IUserStore<AppUser> _userStore;

        public UserController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            IUserStore<AppUser> userStore
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userStore = userStore;
        }

        [HttpPost]
        [Route("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] AppUserViewModel userViewModel)
        {
            var appUser = new AppUser
            {
                Email = userViewModel.Email,
                UserName = userViewModel.UserName,
            };

            IdentityResult result = await _userManager.CreateAsync(appUser, userViewModel.Password);

            if (result.Succeeded)
            {
                return new JsonResult(new { Result = result, Users = _userManager.Users });
            }
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("SignIn")]
        public async Task<IActionResult> SignIn([FromBody] LoginViewModel loginViewModel)
        {
            var appUser = new AppUser
            {
                Email = loginViewModel.Email,
                UserName = loginViewModel.UserName
            };

            var result = await _userManager.FindByEmailAsync(appUser.Email);

            if (result != null)
            {
                SignInResult signInResult = await _signInManager.PasswordSignInAsync(result, loginViewModel.Password, false, false);

                if (signInResult.Succeeded)
                {
                    List<Claim> claims = new List<Claim>()
                    {
                        new Claim(JwtRegisteredClaimNames.Sub, result.UserName),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    };

                    var signInKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Öldürmeyen acıdır."));

                    DateTime expires = DateTime.Now.AddDays(1);

                    var token = new JwtSecurityToken(
                        issuer: "http://localhost:5001",
                        audience: "http://localhost:5001",
                        expires: expires,
                        claims: claims,
                        signingCredentials: new SigningCredentials(signInKey, SecurityAlgorithms.HmacSha256)
                        );

                    return new JsonResult(new
                    {
                        Token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiredToken = expires,
                        Successful = true
                    });
                }
            }

            return new JsonResult(new { Succedded = false });
        }

    }
}
