using System.Collections.Generic;
using System.Threading.Tasks;
using API.AmparoPet.Caregivers.DTO;
using API.AmparoPet.Caregivers.Services;
using API.AmparoPet.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.AmparoPet.Caregivers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarerController : ControllerBase
    {
        private readonly ICarerService _carerService;

        public CarerController(ICarerService carerService)
        {
            _carerService = carerService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Carer>> Get(int id)
        {
            var carer = await _carerService.GetCarerByIdAsync(id);
            if (carer == null)
            {
                return NotFound();
            }

            return carer;
        }

        [HttpGet]
        public async Task<ActionResult<List<Carer>>> GetAll()
        {
            var caregivers = await _carerService.GetAllCareresAsync();
            return caregivers;
        }

        [HttpPost]
        public async Task<ActionResult<Carer>> Create(CarerDto carerDto)
        {
            Carer carer = new Carer();

            var date = DateTime.Now;
            carer.FirstName = carerDto.FirstName;
            carer.LastName = carerDto.LastName;
            carer.CreatedAt = date;
            carer.UpdatedAt = date;
            carer.Email = carerDto.Email;

            var newCarer = await _carerService.CreateCarerAsync(carer);
            return CreatedAtAction(nameof(Get), new { id = newCarer.CarerID }, newCarer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Carer carer)
        {
            if (id != carer.CarerID)
            {
                return BadRequest();
            }

            var updatedCarer = await _carerService.UpdateCarerAsync(carer);
            if (updatedCarer == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _carerService.DeleteCarerAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
