using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarkodluSatis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IslemOzetController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public IslemOzetController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("IslemOzetList")]
        public async Task<IActionResult> GetAllIslemOzetAsync()
        {
            try
            {
                var islemOzets= await _serviceManager.IslemOzetService.GetAllIslemOzetAsync();
                return Ok(islemOzets);
            }
            catch(Exception ex)
            {
                return BadRequest($"Failed to getAll: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneIslemOzetAsync([FromRoute(Name ="id")] int id)
        {
            try
            {
                var islemOzets=await _serviceManager.IslemOzetService.GetOneIslemOzetAsync(id);
                if(islemOzets is null)
                    return NotFound();
                return Ok(islemOzets);
            }
            catch(Exception ex)
            {
                return BadRequest($"Failed to get: {ex.Message}");
            }
        }

        [HttpPost("IslemOzetAdd")]
        public async Task<IActionResult> AddOneIslemOzetAsync([FromBody] IslemOzet islemOzet)
        {
            try
            {
                if (islemOzet is null)
                    return BadRequest();
                await _serviceManager.IslemOzetService.AddOneIslemOzetAsync(islemOzet);
                return StatusCode(201,islemOzet); 

            }
            catch( Exception ex )
            {
                return BadRequest($"Failed to add: {ex.Message}");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneIslemOzetAsync([FromRoute(Name ="id")] int id, [FromBody] IslemOzet islemOzet)
        {
            try
            {
                if (islemOzet is null)
                    return BadRequest();
                await _serviceManager.IslemOzetService.UpdateOneIslemOzetasync(id,islemOzet);
                return StatusCode(201,islemOzet);
            }
            catch(Exception ex)
            {
                return BadRequest($"Failed to update: {ex.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneIslemOzetAsync([FromRoute(Name ="id")] int id)
        {
            try
            {
                await _serviceManager.IslemOzetService.DeleteOneIslemOzetAsync(id);
                return NoContent();
            }
            catch( Exception ex )
            {
                return BadRequest($"Failed to delete: {ex.Message}");
            }
        }
    }
}
