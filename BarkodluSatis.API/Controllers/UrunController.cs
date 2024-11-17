using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarkodluSatis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UrunController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUrunAsync()
        {
            try
            {
                var urun = await _serviceManager.UrunService.GetAllUrunAsync();
                return Ok(urun);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to getAll: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneUrunAsync([FromRoute(Name = "id")] int id)
        {

            try
            {
                var urun = await _serviceManager.UrunService.GetOneUrunAsync(id);
                if (urun is null)
                    return NotFound();
                return Ok(urun);

            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to get: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddOneUrunAsync([FromBody] Urun urun)
        {
            try
            {
                if (urun is null)
                    return BadRequest();//400
                await _serviceManager.UrunService.AddOneUrunAsync(urun);
                return StatusCode(201, urun);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to add {ex.Message}");
            }

        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneUrunAsync([FromRoute(Name = "id")] int id, [FromBody] Urun urun)
        {
            try
            {
                if (urun is null)
                    return BadRequest();//400
                await _serviceManager.UrunService.UpdateOneUrunAsync(id, urun);
                return StatusCode(201, urun);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to update {ex.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneUrunAsync([FromRoute(Name = "id")] int id)
        {
            try
            {
                await _serviceManager.UrunService.DeleteOneUrunAsync(id);
                return NoContent(); //204
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to delete {ex.Message}");
            }
        }
    }
}
