using API.AmparoPet.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.AmparoPet.Controllers
{
    public class AddressController : Controller
    {
        public IActionResult Index()
        {
            var Address = new Address();
            Address.Cep = "97105255";
            Address.Logradouro = "Rua Robson Flores";
            Address.Complemento = "(N Res Fernando Ferrari)";
            Address.Bairro = "Camobi";
            Address.Localidade = "Santa Maria";
            Address.UF = "RS";

            return View();
        }
    }
}
