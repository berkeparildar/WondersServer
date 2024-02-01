using Microsoft.AspNetCore.Mvc;

namespace WondersServer.Controllers;
[ApiController]
[Route("api/countries")]
public class CountryController : ControllerBase
{
    [HttpGet("{countryName}")]
    public IActionResult GetCountryName(string countryName)
    {
        string filePath = Path.Combine("Data", $"{countryName}.json");
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