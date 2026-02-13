// 💪 Exercice 2 : Calculateur d'IMC (Indice de Masse Corporelle)
// Specs :
// Créer une console app qui :

// Demande le poids (en kg)
// Demande la taille (en mètres, ex: 1.75)
// Calcule l'IMC : IMC = poids / (taille × taille)
// Affiche le résultat
// Bonus : Affiche l'interprétation selon la catégorie

//1. demander le poids et la taille
Console.WriteLine("Rentrez votre poids");
double weight = double.Parse(Console.ReadLine());
Console.WriteLine("Votre poids est :" + weight);

Console.WriteLine("Rentrez votre taille");
double height = double.Parse(Console.ReadLine());
Console.WriteLine("Votre taille est :" + height);

//2. calculer IMC
double imc = weight /(height * height);
Console.WriteLine("Votre IMC est : " + imc);

//3. interprétations :
if (imc < 18.5)
{
    Console.WriteLine("Insuffisance pondérale");
} else if (imc <= 24.9 && imc >= 18.5)
{
    Console.WriteLine("Poids normal");

} else if (imc <= 29.9 && imc>= 25)
{
    Console.WriteLine("En surpoids");

} else if (imc >= 30)
{
    Console.WriteLine("Obésité");

}