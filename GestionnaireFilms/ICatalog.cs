public interface ICatalog
{
    void AjouterFilm(Film film);
    List<Film> ObtenirTous();
    List<Film> FiltrerParGenre(string genre);
    List<Film> RangerParNote();
}