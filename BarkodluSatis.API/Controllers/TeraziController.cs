using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarkodluSatis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeraziController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public TeraziController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("TeraziList")]
        public async Task<IActionResult> GetAllTeraziAsync()
        {
            try
            {
                var terazi = await _serviceManager.TeraziService.GetAllTeraziAsync();
                return Ok(terazi);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to getAll: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneTeraziAsync([FromRoute(Name = "id")] int id)
        {

            try
            {
                var terazi = await _serviceManager.TeraziService.GetOneTeraziAsync(id);
                if (terazi is null)
                    return NotFound();
                return Ok(terazi);

            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to get: {ex.Message}");
            }
        }

        [HttpPost("TeraziAdd")]
        public async Task<IActionResult> AddOneTeraziAsync([FromBody] Terazi terazi)
        {
            try
            {
                if (terazi is null)
                    return BadRequest();//400
                await _serviceManager.TeraziService.AddOneTeraziAsync(terazi);
                return StatusCode(201, terazi);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to add {ex.Message}");
            }

        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneTeraziAsync([FromRoute(Name = "id")] int id, [FromBody] Terazi terazi)
        {
            try
            {
                if (terazi is null)
                    return BadRequest();//400
                await _serviceManager.TeraziService.UpdateOneTeraziAsync(id, terazi);
                return StatusCode(201, terazi);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to update {ex.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneTeraziAsync([FromRoute(Name = "id")] int id)
        {
            try
            {
                await _serviceManager.TeraziService.DeleteOneTeraziAsync(id);
                return NoContent(); //204
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to delete {ex.Message}");
            }
        }
    }
}
