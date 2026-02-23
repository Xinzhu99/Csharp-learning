
public interface ITransactionService
{
    List<Transaction> ObtenirDebit();
    List<Transaction> ObtenirCredits();
    List<Transaction> ObtenirGrossesDepenses();
    double CalculSoldes();
    IEnumerable<IGrouping< string, Transaction>> DepensesParCategorie();
    List<Transaction> ObtenirParDate();
    IGrouping< string, Transaction> CategoriePlusDepensiere();

}