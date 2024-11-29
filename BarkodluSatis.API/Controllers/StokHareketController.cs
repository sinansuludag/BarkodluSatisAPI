using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarkodluSatis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StokHareketController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public StokHareketController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("StokHareketList")]
        public async Task<IActionResult> GetAllStokHareketAsync()
        {
            try
            {
                var stokHareket = await _serviceManager.StokHareketService.GetAllStokHareketAsync();
                return Ok(stokHareket);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to getAll: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneStokHareketAsync([FromRoute(Name = "id")] int id)
        {

            try
            {
                var stokHareket = await _serviceManager.StokHareketService.GetOneStokHareketAsync(id);
                if (stokHareket is null)
                    return NotFound();
                return Ok(stokHareket);

            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to get: {ex.Message}");
            }
        }

        [HttpPost("StokHareketAdd")]
        public async Task<IActionResult> AddOneStokHareketAsync([FromBody] StokHareket stokHareket)
        {
            try
            {
                if (stokHareket is null)
                    return BadRequest();//400
                await _serviceManager.StokHareketService.AddOneStokHareketAsync(stokHareket);
                return StatusCode(201, stokHareket);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to add {ex.Message}");
            }

        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneStokHareketAsync([FromRoute(Name = "id")] int id, [FromBody] StokHareket stokHareket)
        {
            try
            {
                if (stokHareket is null)
                    return BadRequest();//400
                await _serviceManager.StokHareketService.UpdateOneStokHareketAsync(id, stokHareket);
                return StatusCode(201, stokHareket);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to update {ex.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneStokHareketAsync([FromRoute(Name = "id")] int id)
        {
            try
            {
                await _serviceManager.StokHareketService.DeleteOneStokHareketAsync(id);
                return NoContent(); //204
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to delete {ex.Message}");
            }
        }
    }
}
