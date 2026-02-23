
using System.Text.Json;

string jsonString = File.ReadAllText("data.json");

var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

List<Transaction> transactions = JsonSerializer.Deserialize<List<Transaction>>(jsonString);
Console.WriteLine($"{transactions.Count()}");