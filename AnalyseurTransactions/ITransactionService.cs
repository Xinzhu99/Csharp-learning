
public interface ITransactionService
{
    List<Transaction> ObtenirDebit();
    List<Transaction> ObtenirCredits();
    List<Transaction> ObtenirGrossesDepenses();
    double CalculSoldes();
    IEnumerable <dynamic> DepensesParCategorie();
    List<Transaction> ObtenirParDate();
    dynamic CategoriePlusDepensiere();

}