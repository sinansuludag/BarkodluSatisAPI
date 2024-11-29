using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarkodluSatis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public KullaniciController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("KullaniciList")]
        public async Task<IActionResult> GetAllKullaniciAsync()
        {
            try
            {
                var kullanicilar=await _serviceManager.KullaniciService.GetAllKullaniciAsync();
                return Ok(kullanicilar);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to getAll: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneKullaniciAsync([FromRoute(Name ="id")] int id)
        {
            try
            {
                var kullanicilar=await _serviceManager.KullaniciService.GetOneKullaniciAsync(id);
                if (kullanicilar is null)
                    return NotFound();
                return Ok(kullanicilar);

            }
            catch(Exception ex)
            {
                return BadRequest($"Failed to get: {ex.Message}");
            }
        }


        [HttpPost("KullaniciAdd")]
        public async Task<IActionResult> AddOneKullaniciAsync([FromBody] Kullanici kullanici)
        {
            try
            {
                if (kullanici is null)
                    return BadRequest();
                await _serviceManager.KullaniciService.AddOneKullaniciAsync(kullanici);
                return StatusCode(201,kullanici);
            }
            catch(Exception ex)
            {
                return BadRequest($"Failed to add: {ex.Message}");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneKullaniciAsync([FromRoute(Name ="id")] int id, [FromBody] Kullanici kullanici)
        {
            try
            {
                if(kullanici is null)   
                    return BadRequest();
                await _serviceManager.KullaniciService.UpdateOneKullaniciAsync(id,kullanici);
                return StatusCode(201,kullanici);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to update: {ex.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneKullaniciAsync([FromRoute(Name ="id")] int id)
        {
            try
            {
                await _serviceManager.KullaniciService.DeleteOneKullaniciAsync(id);
                return NoContent();
            }
            catch(Exception ex)
            {
             return BadRequest($"Failed to delete: {ex.Message}");
            }
        }


    }
}
