
using System.Text.Json;

string jsonString = File.ReadAllText("data.json");

var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

List<Transaction> transactions = JsonSerializer.Deserialize<List<Transaction>>(jsonString, options);
Console.WriteLine($"{transactions.Count}");

ITransactionService service = new TransactionService(transactions);

Console.WriteLine(transactions[0].Type);
Console.WriteLine(transactions[0].Description);

//afficher que les depenses
Console.WriteLine("===MES DEPENSES===");
foreach (var t in service.ObtenirDebit())
{
    Console.WriteLine($"{t.Description}: {t.Montant}");
}
//afficher les revenus
Console.WriteLine("===MES REVENUS===");

foreach (var t in service.ObtenirCredits())
{
    Console.WriteLine($"{t.Description}: {t.Montant}");
}
//afficher les grosses depenses
Console.WriteLine("===MES DEPENSES PLUS DE 100===");
foreach (var t in service.ObtenirGrossesDepenses())
{
    Console.WriteLine($"{t.Description}: {t.Montant}");
}
//afficher le solde
Console.WriteLine("===SOLDE===");
Console.WriteLine($"Solde : {service.CalculSoldes()}");
//afficher les depenses par cat
Console.WriteLine("===DEPENSES PAR CAT===");
foreach(var cat in service.DepensesParCategorie())
{
    Console.WriteLine($"{cat.Categorie} : {cat.Total}");
}
//afficher les depenses par date
Console.WriteLine("===DEPENSES PAR date===");

foreach(var t in service.ObtenirParDate())
{
    Console.WriteLine($"{t.Date.ToString("d")} --- {t.Description} : {t.Montant}");
}
//afficher la cat la plus depensiere
Console.WriteLine("===DEPENSES la plus grosse===");
var category = service.CategoriePlusDepensiere();
Console.WriteLine($"{category.Categorie}: {category.Total}");