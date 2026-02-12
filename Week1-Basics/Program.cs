Console.WriteLine("Tapez C pour Celsius ou F pour Fahrenheit");

//lire le choix de l'user et stocker dans variable "choix"
string choix = Console.ReadLine();

Console.WriteLine("Vous avez tapé : " + choix);

if(choix != "C" || choix!= "F")
{
    Console.WriteLine("Erreur, taper C ou F");
    choix = Console.ReadLine();
 }

 Console.WriteLine("Choix validé :" + choix);
