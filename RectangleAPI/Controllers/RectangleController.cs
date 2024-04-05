using Microsoft.AspNetCore.Mvc;
using RectangleAPI.DTOs;
using System.Text.Json;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RectangleController : ControllerBase
    {
        private readonly string jsonFilePath = $"{Directory.GetCurrentDirectory()}\\Dimensions.json";

        [HttpGet]
        public async Task<IActionResult> GetDimensionsAsync()
        {
            try
            {
                Dimensions currentDimensions = await ReadJsonFile();

                return Ok(currentDimensions); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDimensionsAsync(Dimensions dimensions)
        {
            try
            {
                Dimensions currentDimensions = await ReadJsonFile();

                currentDimensions.Width = dimensions.Width;
                currentDimensions.Height = dimensions.Height;

                string updatedJsonData = JsonSerializer.Serialize(currentDimensions);

                await System.IO.File.WriteAllTextAsync(jsonFilePath, updatedJsonData);

                return NoContent(); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        private async Task<Dimensions> ReadJsonFile()
        {
            string jsonData = await System.IO.File.ReadAllTextAsync(jsonFilePath);

            return JsonSerializer.Deserialize<Dimensions>(jsonData);
        }
    }
}
