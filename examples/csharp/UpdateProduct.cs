// Change Alerts and Checks – C# example (.NET 6+, top-level statements)
// Usage: dotnet new console -n Example && copy this file to Program.cs, then WALTRACK_API_KEY=your-key dotnet run
using System.Text;
using System.Text.Json;

var apiKey = Environment.GetEnvironmentVariable("WALTRACK_API_KEY") ?? throw new InvalidOperationException("Set WALTRACK_API_KEY");
using var http = new HttpClient { Timeout = TimeSpan.FromSeconds(120) };
http.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);

var body = new StringContent(@"{""target_price"": 65, ""interval_minutes"": 360}", Encoding.UTF8, "application/json");
var request = new HttpRequestMessage(new HttpMethod("PATCH"), "https://www.waltrack.dev/api/v1/products/8f0b3c7e-2a4d-4e51-9c1a-6d2f1b9e7a30") { Content = body };
var response = await http.SendAsync(request);
if (!response.IsSuccessStatusCode)
{
    Console.Error.WriteLine($"HTTP {(int)response.StatusCode}: {await response.Content.ReadAsStringAsync()}");
    return;
}

using var doc = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
Console.WriteLine(JsonSerializer.Serialize(doc, new JsonSerializerOptions { WriteIndented = true }));
