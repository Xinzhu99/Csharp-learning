public interface IPlaylist
{
    void AjouterChanson (Chanson chanson);
    List<Chanson> ObtenirToutes();
    List<Chanson> FiltrerParAriste(string Artist);
    List<Chanson> ObtenirParEcoutes();
}