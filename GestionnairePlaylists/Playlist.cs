public class Playlist: IPlaylist
{
    private List<Chanson> _chansons = new List<Chanson> ();

    public void AjouterChanson(Chanson chanson)
    {
        _chansons.Add(chanson);
    }

    public List<Chanson> ObtenirToutes()
    {
        return _chansons;
    }

    public List<Chanson> FiltrerParAriste(string artist)
    {
        return _chansons.Where(chanson => chanson.Artist == artist).ToList();
    }
    public List<Chanson> ObtenirParEcoutes()
    {
        return _chansons.OrderByDescending(chanson => chanson.TotalPlays).ToList();
    }

    // public List<Chanson> ObtenirChansonPlusEcoutee()
    // {
    //     return _chansons.OrderByDescending(chanson => chanson.TotalPlays).First();
    // }
}