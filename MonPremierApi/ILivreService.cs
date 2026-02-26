public interface ILivreService
{
    List<Livre> ObtenirTous();
    Livre ObtenirParId(int id);
    Livre Ajouter(Livre livre);
    Livre Modifier(int id, Livre livreModifie);
    bool Supprimer(int id);//retourne true quand cest supprimé, false quand c'est pas trouvé
}