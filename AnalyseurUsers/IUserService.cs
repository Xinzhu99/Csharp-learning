public interface IUserService
{
    List<User> ObtenirPremiumUsers();
    List<User> ObtenirParisUsers();
    List<User> RangerParCommande();
    double ObtenirLaMoyenne();
    IEnumerable<IGrouping<string, User>> GroupeParVille();
}