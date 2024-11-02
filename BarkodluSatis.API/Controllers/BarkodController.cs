using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarkodluSatis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarkodController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public BarkodController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBarkodAsync()
        {
            try
            {
               var barkods=await _serviceManager.BarkodService.GetAllBarkodAsync();
                return Ok(barkods);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddOneBarkodAsync([FromBody] Barkod barkod)
        {
            try
            {
                if (barkod is null)
                    return BadRequest();//400
                await _serviceManager.BarkodService.AddOneBarkodAsync(barkod);
                return StatusCode(201, barkod);
            }
            catch (Exception ex)
            {
                return BadRequest($"Hata: {ex.Message}");
            }

        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneBarkod([FromRoute(Name ="id")] int id, [FromBody] Barkod barkod)
        {
            try
            {
                if (barkod is null)
                    return BadRequest();//400
               await _serviceManager.BarkodService.UpdateOneBarkodAsync(id,barkod);
                return NoContent(); //204
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneBarkod([FromRoute(Name ="id")] int id)
        {
            try
            {
               await _serviceManager.BarkodService.DeleteOneBarkodAsync(id);
                return NoContent(); //204
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
