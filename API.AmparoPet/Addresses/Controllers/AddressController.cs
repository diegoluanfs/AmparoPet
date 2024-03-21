using API.AmparoPet.Addresses.Services;
using API.AmparoPet.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.AmparoPet.Addresses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> Get(int id)
        {
            var address = await _addressService.GetAddressByIdAsync(id);
            if (address == null)
            {
                return NotFound();
            }

            return address;
        }

        [HttpGet]
        public async Task<ActionResult<List<Address>>> GetAll()
        {
            var addresses = await _addressService.GetAllAddressesAsync();
            return addresses;
        }

        [HttpPost]
        public async Task<ActionResult<Address>> Create(Address addresses)
        {

            var address = new Address();
            address.Cep = "97105255";
            address.Logradouro = "Rua Robson Flores";
            address.Complemento = "(N Res Fernando Ferrari)";
            address.Bairro = "Camobi";
            address.Localidade = "Santa Maria";
            address.UF = "RS";

            var newAddress = await _addressService.CreateAddressAsync(address);
            return CreatedAtAction(nameof(Get), new { id = newAddress.AddressID }, newAddress);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Address address)
        {
            if (id != address.AddressID)
            {
                return BadRequest();
            }

            var updatedAddress = await _addressService.UpdateAddressAsync(address);
            if (updatedAddress == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _addressService.DeleteAddressAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
