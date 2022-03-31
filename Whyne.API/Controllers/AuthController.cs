using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Whyne.Models;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Whyne.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AuthController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] Account account)
        {
            IdentityUser user = new() {UserName = account.UserName, Email = account.Email};
            IdentityResult result = await _userManager.CreateAsync(user, account.Password);
            return Ok(result);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] Credentials credentials)
        {
            IdentityUser user = await _userManager.FindByEmailAsync(credentials.Email);

            if (user != null)
            {
                SignInResult result =
                    await _signInManager
                        .PasswordSignInAsync(user, credentials.Password, false, false);
                if (result.Succeeded)
                {
                    return Ok(
                        new User
                        {
                            Email = user.Email,
                            PhoneNumber = user.PhoneNumber,
                            UserName = user.UserName
                        }
                    );
                }

                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            if (_signInManager.IsSignedIn(User)) await _signInManager.SignOutAsync();
            return Ok();
        }
    }
}