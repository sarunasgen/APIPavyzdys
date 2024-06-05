using System.Text.Json.Serialization;

namespace APIPavyzdys
{
    public class Animal
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("age")]
        public int Age { get; set; }

    }
}
