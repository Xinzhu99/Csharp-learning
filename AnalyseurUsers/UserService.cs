//!!!! a quoi ça sert mon fichier UserService :
// à définir les règles de manipulation des users
//principe : une classe = une responsablité 
//program.cs : charger la data et affichier la data 
public class UserService : IUserService
{
    private List<User> _users;
    public UserService(List<User> users)
    {
        _users = users;
    }

    public List<User> ObtenirPremiumUsers()
    {
        return _users.Where(user => user.Abonnement == "Premium").ToList();
    }

    public List<User> ObtenirParisUsers()
    {
        return _users.Where(user => user.Ville == "Paris").ToList();
    }

    public List<User> RangerParCommande()
    {
        return _users.OrderByDescending(user => user.NbCommandes).ToList();

    }

    public double ObtenirLaMoyenne()
    {
        return _users.Average(user => user.Age);
    }

    public IEnumerable<IGrouping<string, User>> GroupeParVille()
    {
        return _users.GroupBy(user => user.Ville).ToList();
    }
    }