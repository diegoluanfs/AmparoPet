using API.AmparoPet.Models;
using API.AmparoPet.Pets.Models.DTO;
using API.AmparoPet.Pets.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.AmparoPet.Pets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pet>> Get(int id)
        {
            var pet = await _petService.GetPetByIdAsync(id);
            if (pet == null)
            {
                return NotFound();
            }

            return pet;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pet>>> GetAll()
        {
            var pets = await _petService.GetAllPetesAsync();
            return pets;
        }

        [HttpPost]
        public async Task<ActionResult<Pet>> Create(PetDto petDto)
        {
            Pet pet = new Pet();
            pet.DateOfBirth = DateTime.Now;
            pet.Name = petDto.Name;

            var newPet = await _petService.CreatePetAsync(pet);
            return CreatedAtAction(nameof(Get), new { id = newPet.PetID }, newPet);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Pet pet)
        {
            if (id != pet.PetID)
            {
                return BadRequest();
            }

            var updatedPet = await _petService.UpdatePetAsync(pet);
            if (updatedPet == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _petService.DeletePetAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
