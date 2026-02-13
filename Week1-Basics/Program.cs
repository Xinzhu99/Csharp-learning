Console.WriteLine("Tapez C pour Celsius ou F pour Fahrenheit");

//lire le choix de l'user et stocker dans variable "choix"
string choix = Console.ReadLine();

Console.WriteLine("Vous avez tapé : " + choix);

if(choix != "C" && choix!= "F")
{
    Console.WriteLine("Erreur, taper C ou F");
    choix = Console.ReadLine();
 }

 Console.WriteLine("Choix validé :" + choix);

//demander un input de température en string et le convertir en double
// string input = Console.ReadLine();
Console.WriteLine("Tapez la température :");
double temperature = double.Parse(Console.ReadLine());
Console.WriteLine(temperature);

if(choix == "C")
{
    double resultat = (temperature * 9/5) + 32;
    Console.WriteLine($"Your converted temperature is : {resultat} F");
}else if (choix == "F")
{
    double resultat = (temperature - 32) * 5/9;
    Console.WriteLine($"Your converted temperature is : {resultat} C");

}

