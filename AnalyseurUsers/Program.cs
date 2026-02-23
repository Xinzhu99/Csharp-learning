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

//!!!!!
IUserService service = new UserService(users);

var premiumUsers = service.ObtenirPremiumUsers();
foreach (var user in premiumUsers)
{
    Console.WriteLine($"{user.Nom}");
}
//2=== les users de paris
Console.WriteLine("===users in Paris");
var parisUsers = service.ObtenirParisUsers();
foreach (var user in parisUsers)
{
    Console.WriteLine($"{user.Nom}");
}
//3=== l'user avec le plus de commandes
var usersByOrders = service.RangerParCommande();
Console.WriteLine($"User avec le plus de commandes : {usersByOrders[0].Nom} - {usersByOrders[0].NbCommandes} commandes");
//4=== la moyenne d'age
var averageAge = service.ObtenirLaMoyenne();
Console.WriteLine($"L'age moyen : ${averageAge:F1}");
//5=== le nombre d'utilisateurs par ville
var usersByCity = service.GroupeParVille();
foreach (var group in usersByCity)
{
    Console.WriteLine($"{group.Key} : {group.Count()} users");
}