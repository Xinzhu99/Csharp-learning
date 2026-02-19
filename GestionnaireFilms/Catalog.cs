public class Catalog : ICatalog  // "je promets de respecter le contrat"
{
    // La liste privée qui stocke les films en mémoire
    private List<Film> _films = new List<Film>();

    public void AjouterFilm(Film film)
    {
        _films.Add(film);
    }

    public List<Film> ObtenirTous()
    {
        return _films;
    }

    public List<Film> FiltrerParGenre(string genre)
    {
        // 👀 On laisse ça vide pour l'instant — on le remplit à l'heure 2 avec LINQ !
        return _films.Where(film => film.Genre == genre).ToList();
    }
    public List<Film> RangerParNote()
    {
        return _films.OrderByDescending(film => film.Note).ToList();
    }
}