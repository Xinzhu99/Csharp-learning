
using System.Collections.Generic;
using System.Globalization;

List <Transaction> transactions = new List<Transaction>();

while (true)
{
    Console.WriteLine("\n=== GESTIONNAIRE DE BUDGET ===");
    Console.WriteLine("1. Ajouter un revenu");
    Console.WriteLine("2. Ajouter une dépense");
    Console.WriteLine("3. Afficher toutes les transactions");
    Console.WriteLine("4. Voir les soldes");
    Console.WriteLine("5. Quitter");
    Console.Write("Votre choix : ");

    string choix = Console.ReadLine();

    if(choix == "1")
    {
        //ajouter un revenu
        //-stocker input description
        //stocker le montant
        //stocker le type
        //add transac

        Console.WriteLine("Tapez la description du revenu");
        string inputDescript = Console.ReadLine();
        Console.WriteLine("Tapez le montant de la transaction");
        double inputMontant = double.Parse(Console.ReadLine());
         while (inputMontant < 0)
        {
            Console.Write("Montant négatif n'est pas accepté, rentrez un nouveau chiffre :");
            inputMontant = double.Parse(Console.ReadLine());
        }

        Transaction nouvelleTransaction = new Transaction();
        nouvelleTransaction.Description = inputDescript;
        nouvelleTransaction.Montant = inputMontant;
        nouvelleTransaction.Type = "Revenu";

        transactions.Add(nouvelleTransaction);
        Console.WriteLine("NOUVEAU REVENU AJOUTÉ !");

    }

    if(choix == "2")
    {
        Console.WriteLine("Tapez la description de la dépense");
        string inputDescript = Console.ReadLine();
        Console.WriteLine("Tapez le montant de la transaction");
        double inputMontant = double.Parse(Console.ReadLine());

        while (inputMontant < 0)
        {
            Console.Write("Montant négatif n'est pas accepté, rentrez un nouveau chiffre :");
          inputMontant = double.Parse(Console.ReadLine());
        }

        Transaction nouvelleTransaction = new Transaction();
        nouvelleTransaction.Description = inputDescript;
        nouvelleTransaction.Montant = inputMontant;
        nouvelleTransaction.Type = "Dépense";

        transactions.Add(nouvelleTransaction);
        Console.WriteLine("NOUVELLE DEPENSE AJOUTÉE !");
        
    }
    if(choix == "3")
    {
        for(int i = 0; i<transactions.Count; i++)
        {
            
            Console.WriteLine($"{transactions[i].Type} --- {transactions[i].Description} : {transactions[i].Montant}");
        };
    }
    if(choix == "4")
    {
        double totalRevenu = 0;
        double totalDepense = 0;

        for(int i=0; i<transactions.Count; i++)
        {
            if(transactions[i].Type == "Revenu")
            {
                totalRevenu += transactions[i].Montant;
            }else if (transactions[i].Type == "Dépense")
            {
                totalDepense += transactions[i].Montant;
            }
        }
        double solde = totalRevenu - totalDepense;
        Console.WriteLine($"Total : {solde}");
    }
    if(choix == "5")
    {
        //quitter
        Console.WriteLine("Au revoir!");
        break;
    }
}
//déclarer ma moule
class Transaction
{
    public string Description {get; set; }
    public double Montant { get; set; }
    public string Type { get; set; }
}