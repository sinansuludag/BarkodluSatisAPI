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
        public IActionResult GetAllBarkods()
        {
            try
            {
               var barkods=_serviceManager.BarkodService.GetAllBarkods();
                return Ok(barkods);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddOneBarkod([FromBody] Barkod barkod)
        {
            try
            {
                if (barkod is null)
                    return BadRequest();//400
                _serviceManager.BarkodService.AddOneBarkod(barkod);
                return StatusCode(201, barkod);
            }
            catch (Exception ex)
            {
                return BadRequest($"Hata: {ex.Message}");
            }

        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneBarkod([FromRoute(Name ="id")] int id, [FromBody] Barkod barkod)
        {
            try
            {
                if (barkod is null)
                    return BadRequest();//400
                _serviceManager.BarkodService.UpdateOneBarkod(id,barkod);
                return NoContent(); //204
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneBarkod([FromRoute(Name ="id")] int id)
        {
            try
            {
                _serviceManager.BarkodService.DeleteOneBarkod(id);
                return NoContent(); //204
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
