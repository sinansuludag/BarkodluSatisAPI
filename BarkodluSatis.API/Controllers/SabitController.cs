using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BarkodluSatis.BLL.EFCore;
using BarkodluSatis.DLL.BarkodDBObjects;
using BarkodluSatis.DLL.Contracts;
using BarkodluSatis.BLL.Contracts;

namespace BarkodluSatis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SabitController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public SabitController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }


        [HttpGet]
        public async Task<ActionResult> GetAllSabitAsync()
        {
            try
            {
                var sabits=await _serviceManager.SabitService.GetAllSabitAsync();
                return Ok(sabits);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to getAll: {ex.Message}");
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> GetOneSabitAsync([FromRoute(Name ="id")] int id)
        {
            try
            {
                var sabit = await _serviceManager.SabitService.GetOneSabitAsync(id);
                if (sabit is null)
                    return NotFound();
                return Ok(sabit);

            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to get: {ex.Message}");
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOneSabitAsync([FromRoute(Name ="id")] int id,[FromBody] Sabit sabit)
        {
                try
                {
                    if(sabit is null)
                        return BadRequest();
                    await _serviceManager.SabitService.UpdateOneSabitAsync(id,sabit);
                    return StatusCode(201,sabit);
                } 
                catch (Exception ex)
                {
                    return BadRequest($"Failed to Update: {ex.Message}");
                }
        }

        [HttpPost]
        public async Task<ActionResult> AddOneSabitAsync([FromBody] Sabit sabit)
        {
            try
            {
                if (sabit is null)
                    return BadRequest();
                await _serviceManager.SabitService.AddOneSabitAsync(sabit);
                return StatusCode(201,sabit);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to Add: {ex.Message}");
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOneSabitAsync([FromRoute(Name ="id")] int id)
        {
            try
            {
                await _serviceManager.SabitService.DeleteOneSabitAsync(id);
                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest($"Failed to Delete: {ex.Message}");
            }
        }

    }
}
