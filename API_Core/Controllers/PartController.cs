using System;
using System.Security.Claims;
using System.Threading.Tasks;
using INK_API.Helpers;
using INK_API._Services.Interface;
using INK_API.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace INK_API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PartController : ControllerBase
    {
        private readonly IPartService _partService;
        public PartController(IPartService partService)
        {
            _partService = partService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var lines = await _partService.GetAllAsync();
            return Ok(lines);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPartByScheduleID(int id)
        {
            var part = await _partService.GetPartByScheduleID(id);
            return Ok(part);
        }


        [HttpPost]
        public async Task<IActionResult> Create(PartDto create)
        {
            return Ok(await _partService.Add(create));
        }

        [HttpPut]
        public async Task<IActionResult> Update(PartDto update)
        {
            if (await _partService.Update(update))
                return NoContent();
            return BadRequest($"Updating Part {update.ID} failed on save");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePart(PartInkChemicalDto update)
        {
            return Ok(await _partService.UpdatePart(update));
            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _partService.Deletes(id))
                return NoContent();
            throw new Exception("Error deleting the Part");
        }
    }
}