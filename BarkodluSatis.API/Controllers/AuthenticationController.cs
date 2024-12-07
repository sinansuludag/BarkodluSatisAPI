using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarkodluSatis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public AuthenticationController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] User user)
        {
            try
            {
                if (user is null)
                    return BadRequest();//400
                await _serviceManager.AuthenticationService.RegisterUser(user);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to register {ex.Message}");
            }
        }
    }
}
