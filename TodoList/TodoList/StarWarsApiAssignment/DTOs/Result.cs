using System.Text.Json.Serialization;

namespace StarWarsApiAssignment.DTOs;
public record Result(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("rotation_period")] string rotation_period,
        [property: JsonPropertyName("orbital_period")] string orbital_period,
        [property: JsonPropertyName("diameter")] string diameter,
        [property: JsonPropertyName("climate")] string climate,
        [property: JsonPropertyName("gravity")] string gravity,
        [property: JsonPropertyName("terrain")] string terrain,
        [property: JsonPropertyName("surface_water")] string surface_water,
        [property: JsonPropertyName("population")] string population,
        [property: JsonIgnore] IReadOnlyList<string> residents,
        [property: JsonIgnore] IReadOnlyList<string> films,
        [property: JsonIgnore] DateTime created,
        [property: JsonIgnore] DateTime edited,
        [property: JsonIgnore] string url
    );
