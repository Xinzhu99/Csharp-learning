public class LivreService : ILivreService
{
    private List<Livre> _livres;

    public LivreService(List<Livre> data)
    {
        _livres = data;
    }

    public List<Livre> ObtenirTous()
    {
        return _livres;
    }

    public Livre ObtenirParId(int id)
    {
        return _livres.FirstOrDefault(l=>l.Id == id);
    }

    public Livre Ajouter(Livre livre)
    {
        _livres.Add(livre);
        return _livres[_livres.Count-1];
    }

    public Livre Modifier(int id, Livre livreModifie)
    {
        var livre = _livres.FirstOrDefault(l=>l.Id == id);
        if(livre != null)
        {
            livre.Titre = livreModifie.Titre;
            livre.Auteur = livreModifie.Auteur;
            livre.Genre = livreModifie.Genre;
            livre.Annee = livreModifie.Annee;
            livre.Note = livreModifie.Note;   
            return livre;
        }
        return null;
    }

    public bool Supprimer(int id)
    {
        var livre = _livres.FirstOrDefault(l=>l.Id == id);
        if(livre != null)
        {
            _livres.Remove(livre);
            return true;
        }
        return false;
    }
}