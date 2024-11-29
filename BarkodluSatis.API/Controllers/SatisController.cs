using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarkodluSatis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SatisController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public SatisController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("SatisList")]
        public async Task<IActionResult> GetAllSatisAsync()
        {
            try
            {
                var satis = await _serviceManager.SatisService.GetAllSatisAsync();
                return Ok(satis);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to getAll: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneSatisAsync([FromRoute(Name = "id")] int id)
        {

            try
            {
                var satis = await _serviceManager.SatisService.GetOneSatisAsync(id);
                if (satis is null)
                    return NotFound();
                return Ok(satis);

            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to get: {ex.Message}");
            }
        }

        [HttpPost("SatisAdd")]
        public async Task<IActionResult> AddOneSatisAsync([FromBody] Satis satis)
        {
            try
            {
                if (satis is null)
                    return BadRequest();//400
                await _serviceManager.SatisService.AddOneSatisAsync(satis);
                return StatusCode(201, satis);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to add {ex.Message}");
            }

        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneSatisAsync([FromRoute(Name = "id")] int id, [FromBody] Satis satis)
        {
            try
            {
                if (satis is null)
                    return BadRequest();//400
                await _serviceManager.SatisService.UpdateOneSatisAsync(id, satis);
                return StatusCode(201, satis);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to update {ex.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneSatisAsync([FromRoute(Name = "id")] int id)
        {
            try
            {
                await _serviceManager.SatisService.DeleteOneSatisAsync(id);
                return NoContent(); //204
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to delete {ex.Message}");
            }
        }
    }
}
