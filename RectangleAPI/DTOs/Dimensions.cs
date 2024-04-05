using System.Text.Json.Serialization;

namespace RectangleAPI.DTOs
{
    public class Dimensions
    {
        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }
    }
}
