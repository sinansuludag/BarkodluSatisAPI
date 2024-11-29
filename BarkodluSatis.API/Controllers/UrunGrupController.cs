using BarkodluSatis.BLL.Contracts;
using BarkodluSatis.DLL.BarkodDBObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarkodluSatis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunGrupController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UrunGrupController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("UrunGrupList")]
        public async Task<IActionResult> GetAllUrunGrupAsync()
        {
            try
            {
                var urunGrup = await _serviceManager.UrunGrupService.GetAllUrunGrupAsync();
                return Ok(urunGrup);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to getAll: {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneUrunGrupAsync([FromRoute(Name = "id")] int id)
        {

            try
            {
                var urunGrup = await _serviceManager.UrunGrupService.GetOneUrunGrupAsync(id);
                if (urunGrup is null)
                    return NotFound();
                return Ok(urunGrup);

            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to get: {ex.Message}");
            }
        }

        [HttpPost("UrunGrupAdd")]
        public async Task<IActionResult> AddOneTUrunGrupAsync([FromBody] UrunGrup urunGrup)
        {
            try
            {
                if (urunGrup is null)
                    return BadRequest();//400
                await _serviceManager.UrunGrupService.AddOneUrunGrupAsync(urunGrup);
                return StatusCode(201, urunGrup);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to add {ex.Message}");
            }

        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneUrunGrupAsync([FromRoute(Name = "id")] int id, [FromBody] UrunGrup urunGrup)
        {
            try
            {
                if (urunGrup is null)
                    return BadRequest();//400
                await _serviceManager.UrunGrupService.UpdateOneUrunGrupAsync(id, urunGrup);
                return StatusCode(201, urunGrup);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to update {ex.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneUrunGrupAsync([FromRoute(Name = "id")] int id)
        {
            try
            {
                await _serviceManager.UrunGrupService.DeleteOneUrunGrupAsync(id);
                return NoContent(); //204
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to delete {ex.Message}");
            }
        }
    }
}
