using System.Text.Json;
//lire le text du document et stocker text dans jsonstring
string jsonString = File.ReadAllText("user.json");

//convertir le json text en un tableau users d'objets User
var options = new JsonSerializerOptions 
{ 
    PropertyNameCaseInsensitive = true  // ignore majuscules/minuscules
};

List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString, options)!;
Console.WriteLine($"{users.Count} utilisateurs chargés !" );

//afficher tous les users premieum
Console.WriteLine("===Tous les users premium===");
var premiumUsers = users.Where(user => user.Abonnement == "Premium").ToList();
foreach (var user in premiumUsers)
{
    Console.WriteLine($"{user.Nom}");
}
//2=== les users de paris
Console.WriteLine("===users in Paris");
var parisUsers = users.Where(user => user.Ville == "Paris");
foreach (var user in parisUsers)
{
    Console.WriteLine($"{user.Nom}");
}
//3=== l'user avec le plus de commandes
var usersByOrders = users.OrderByDescending(user => user.NbCommandes).ToList();
Console.WriteLine($"User avec le plus de commandes : {usersByOrders[0].Nom} - {usersByOrders[0].NbCommandes} commandes");
//4=== la moyenne d'age
var averageAge = users.Average(user => user.Age);
Console.WriteLine($"L'age moyen : ${averageAge:F1}");
//5=== le nombre d'utilisateurs par ville
var usersByCity = users.GroupBy(user => user.Ville).ToList();
foreach (var group in usersByCity)
{
    Console.WriteLine($"{group.Key} : {group.Count()} users");
}