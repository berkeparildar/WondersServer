using Microsoft.AspNetCore.Mvc;

namespace WondersServer.Controllers;
[ApiController]
[Route("api/countries")]
public class CountryController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCountry()
    {
        string filePath = Path.Combine("Data", "Countries", "countries.json");
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