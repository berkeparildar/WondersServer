using Microsoft.AspNetCore.Mvc;

namespace WondersServer.Controllers;

[ApiController]
[Route("api/sites")]
public class SiteController : Controller
{
    [HttpGet("{countryName}")]
    public IActionResult GetSite(string countryName)
    {
        string filePath = Path.Combine("Data", "Sites", $"{countryName}.json");
        if (System.IO.File.Exists(filePath))
        {
            string jsonData = System.IO.File.ReadAllText(filePath);
            return Content(jsonData, "application/json");
        }
        else
        {
            return NotFound();
        }
    }
}