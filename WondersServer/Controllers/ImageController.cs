using Microsoft.AspNetCore.Mvc;

namespace WondersServer.Controllers;
[ApiController]
[Route("api/image")]
public class ImageController : ControllerBase
{
    [HttpGet("{imageName}")]
    public IActionResult GetImage(string imageName)
    {
        var imagePath = Path.Combine("wwwroot", "images", imageName);
        if (System.IO.File.Exists(imagePath))
        {
            var stream = new FileStream(imagePath, FileMode.Open);
            return File(stream, "image/jpg");
        }
        else
        {
            return NotFound();
        }
    }
}