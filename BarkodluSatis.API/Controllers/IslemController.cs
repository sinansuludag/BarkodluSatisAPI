using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarkodluSatis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IslemController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public IslemController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllIslemAsync()
        {
            try
            {
                var islems = await _serviceManager.IslemService.GetAllIslemAsync();
                return Ok(islems);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to getAll: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneIslemAsync([FromRoute(Name ="id")] int id)
        {
            var islem=await _serviceManager.IslemService.GetOneIslemByIdAsync(id);

            if(islem is null)
                return NotFound();
            return Ok(islem);
        }

        [HttpPost]
        public async Task<IActionResult> AddOneIslemAsync([FromBody] Islem islem)
        {
            try
            {
                if (islem is null)
                    return BadRequest();
                await _serviceManager.IslemService.AddOneIslemAsync(islem);
                return StatusCode(201,islem);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to add: {ex.Message}");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneIslemAsync([FromRoute(Name ="id")] int id, [FromBody] Islem islem)
        {
            try
            {
                if (islem is null)
                    return BadRequest();
                await _serviceManager.IslemService.UpdateOneIslemAsync(id,islem);
                return StatusCode(201, islem);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to update : {ex.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneIslemAsync([FromRoute(Name ="id")] int id)
        {
            try
            {
                await _serviceManager.IslemService.DeleteOneIslemAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to delete {ex.Message}");
            }
        }

    }
}
