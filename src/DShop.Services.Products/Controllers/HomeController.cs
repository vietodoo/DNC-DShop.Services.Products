using Microsoft.AspNetCore.Mvc;

namespace DShop.Services.Products.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get() => Ok("DShop Products Service");
    }
}