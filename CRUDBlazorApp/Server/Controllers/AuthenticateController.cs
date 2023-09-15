using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRUDBlazorApp.Server.Services.AuthenticationService;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

//Code developed by following allow with following course: https://www.udemy.com/course/blazor-ecommerce/learn/
namespace CRUDBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthenticate _authenticate;

        public AuthenticateController(IAuthenticate authenticate) 
        {
            _authenticate = authenticate;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> RegisterUser(UserRegister request)
        {
            var response = await _authenticate.Register(new Shared.User
            {
                Email = request.Email
            }, request.Password);

            if (!response.Success)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLogin request)
        {
            var response = await _authenticate.Login(request.Email, request.Password);
            if(!response.Success) {
                return BadRequest(response);
            }
            GlobalConfig.user = request.Email;
            return Ok(response);
        }

        [HttpPost("change-password"), Authorize]
        public async Task<ActionResult<ServiceResponse<bool>>> ChangePassword([FromBody] string password)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _authenticate.ChangePassword(int.Parse(userId), password);

            if (!response.Success)
            {
                return BadRequest(response.Message);
            }

            return Ok(response);
        }

        
    }
}
