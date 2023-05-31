using System.Text.Json;
using System.Text.Json.Serialization;

namespace app.Models;

public class Snack
{
    private string name = "snack";

    [JsonPropertyName("name")]
    public string Name { get => name; set => name = value; }

    public override string ToString() => JsonSerializer.Serialize<Snack>(this);
}