using LabProject.Core.Services;
using LabProject.Database.Dtos.Request;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LabProject.Api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly AuthenticationService _authenticationService;

        public AuthenticationController(AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] LabProject.Database.Dtos.Request.RegisterRequest request)
        {
            await _authenticationService.Register(request.Username, request.Password, request.Role);
            return Ok("User registered successfully");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LabProject.Database.Dtos.Request.LoginRequest request)
        {
            var token = await _authenticationService.Login(request.Username, request.Password);
            if (token == null)
                return Unauthorized("Invalid credentials");
            var expires = DateTime.UtcNow.AddMinutes(5);
            return Ok(new { Token = token, Expires = expires});
        }
    }
}
