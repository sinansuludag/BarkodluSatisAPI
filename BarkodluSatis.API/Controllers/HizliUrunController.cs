using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BarkodluSatis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HizliUrunController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public HizliUrunController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHizliUrunAsync()
        {
            try
            {
                var hizliUruns = await _serviceManager.HizliUrunService.GetAllHizliUrunAsync();
                return Ok(hizliUruns);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to getAll: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneHizliUrunAsync([FromRoute(Name = "id")] int id)
        {

            try
            {
                var hizliUrun = await _serviceManager.SabitService.GetOneSabitAsync(id);
                if (hizliUrun is null)
                    return NotFound();
                return Ok(hizliUrun);

            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to get: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddOneHizliUrunAsync([FromBody] HizliUrun hizliUrun)
        {
            try
            {
                if (hizliUrun is null)
                    return BadRequest();//400
                await _serviceManager.HizliUrunService.AddOneHizliUrunAsync(hizliUrun);
                return StatusCode(201, hizliUrun);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to add {ex.Message}");
            }

        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneHizliUrunAsync([FromRoute(Name = "id")] int id, [FromBody] HizliUrun hizliUrun)
        {
            try
            {
                if (hizliUrun is null)
                    return BadRequest();//400
                await _serviceManager.HizliUrunService.UpdateOneHizliUrunAsync(id, hizliUrun);
                return StatusCode(201, hizliUrun);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to update {ex.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneHizliUrunAsync([FromRoute(Name = "id")] int id)
        {
            try
            {
                await _serviceManager.HizliUrunService.DeleteOneHizliUrunAsync(id);
                return NoContent(); //204
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to delete {ex.Message}");
            }
        }
    }
}
