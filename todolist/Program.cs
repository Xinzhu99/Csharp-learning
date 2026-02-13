using System.Collections.Generic;
using System.Globalization;


// Créer la liste de tâches
List<Tache> taches = new List<Tache>();

// Menu en boucle
while (true)
{
    Console.WriteLine("\n=== GESTIONNAIRE DE TÂCHES ===");
    Console.WriteLine("1. Ajouter une tâche");
    Console.WriteLine("2. Afficher les tâches");
    Console.WriteLine("3. Marquer comme terminée");
    Console.WriteLine("4. Quitter");
    Console.Write("Votre choix : ");
    
    string choix = Console.ReadLine();
    
    if (choix == "1")
    {
        // TON CODE ICI : Ajouter une tâche
        //stocker le input string
        //list.add
        Console.WriteLine("Votre choix : 1");
        Console.WriteLine("Tapez le nom de tâche");
        string input = Console.ReadLine();

        Tache nouvelleTache = new Tache();
        nouvelleTache.Name = input;
        nouvelleTache.IsCompleted = false;
        taches.Add(nouvelleTache);

        Console.WriteLine("Tâche " + input + " a été ajoutée");
    }
    else if (choix == "2")
    {
        // TON CODE ICI : Afficher les tâches
        //parcouriri ma liste actuelle
        for (int i=0; i<taches.Count; i++)
        {
            if(taches[i].IsCompleted == true)
            {
                Console.Write($"{i+1} : [x]{taches[i].Name}");

            } else if (taches[i].IsCompleted == false)
            {
                Console.Write($"{i+1} : [ ]{taches[i].Name}");

            }
        }
    }
    else if (choix == "3")
    {
        // TON CODE ICI : Marquer comme terminée
        //stocker le input int de l'index de tache 
        Console.WriteLine("Rentrez le numéro de tâche");
        int numeroDeTache = int.Parse(Console.ReadLine());
        taches[numeroDeTache-1].IsCompleted = true;
        Console.WriteLine("Tâche" + numeroDeTache + " a été marquée terminée :!");
    }
    else if (choix == "4")
    {
        Console.WriteLine("Au revoir !");
        break; // Sort de la boucle while
    }
}
class Tache
{
    public string Name { get; set; }
    public bool IsCompleted { get; set; }
}