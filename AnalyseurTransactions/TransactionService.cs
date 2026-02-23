using System.Text.RegularExpressions;
using System.Transactions;

public class TransactionService : ITransactionService
{
    private List<Transaction> _transactions;
    public UserService (List<Transaction> data)
    {
        _transactions = data;
    }

    public List<Transaction> ObtenirDebit()
    {
        return _transactions.Where(transaction => transaction.GetType == "Débit");
    }

     public List<Transaction> ObtenirCredits()
    {
        return _transactions.Where(transaction => transaction.GetType == "Crédit").toList();
    }

    public List<Transaction> ObtenirGrossesDepenses()
    {
        return _transactions.Where(transaction => transaction.GetType == "Débit" && transaction.Montant > 100).toList();
    }

    public double CalculSoldes()
    {
        var totalDebit = _transactions
        .Where(transaction => transaction.Type =="Débit")
        .toList()
        .Sum(transaction => transaction.Montant);

        var totalCredit = _transactions
        .Where(transaction => transaction.Type =="Crédit")
        .toList()
        .Sum(transaction => transaction.Montant);

        return totalCredit - totalDebit;
    }

    public IEnumerable<IGrouping< string, Transaction>> DepensesParCategorie()
    {
        var categories = _transactions.GroupBy( transaction => transaction.Categorie).toList();
    }

}