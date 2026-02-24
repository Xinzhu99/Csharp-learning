using System.Text.RegularExpressions;

public class TransactionService : ITransactionService
{
    private List<Transaction> _transactions;
    public TransactionService (List<Transaction> data)
    {
        _transactions = data;
    }

    public List<Transaction> ObtenirDebit()
    {
        return _transactions.Where(transaction => transaction.Type == "Débit").ToList();
    }

     public List<Transaction> ObtenirCredits()
    {
        return _transactions.Where(transaction => transaction.Type == "Crédit").ToList();
    }

    public List<Transaction> ObtenirGrossesDepenses()
    {
        return _transactions.Where(transaction => transaction.Type == "Débit" && transaction.Montant > 100).ToList();
    }

    public double CalculSoldes()
    {
        var totalDebit = _transactions
        .Where(transaction => transaction.Type =="Débit")
        .ToList()
        .Sum(transaction => transaction.Montant);

        var totalCredit = _transactions
        .Where(transaction => transaction.Type =="Crédit")
        .ToList()
        .Sum(transaction => transaction.Montant);

        return totalCredit - totalDebit;
    }

    public IEnumerable<dynamic> DepensesParCategorie()
    {
        return _transactions.Where(transaction => transaction.Type == "Débit")
        .GroupBy( transaction => transaction.Categorie)
        .Select(group => new
        {
            Categorie = group.Key,
            Total = group.Sum(t => t.Montant)
        });
    }

    public List<Transaction> ObtenirParDate()
    {
        return _transactions.OrderByDescending(transaction => transaction.Date).ToList();
    }

    public dynamic CategoriePlusDepensiere()
    {
        return _transactions.Where(transaction => transaction.Type == "Débit")
        .GroupBy(transaction => transaction.Categorie)
        .Select(group => new 
        {
            Categorie = group.Key,
            Total = group.Sum(t => t.Montant)
            
        })
        .OrderByDescending(g => g.Total)
        .First();
    }
}