using System.Data.Common;

IPlaylist playlist = new Playlist();

playlist.AjouterChanson(new Chanson { Id = 1, Title = "Blinding Lights", Artist = "The Weeknd", Genre = "Pop", Duration = 200, TotalPlays = 3500000 });
playlist.AjouterChanson(new Chanson { Id = 2, Title = "Starboy", Artist = "The Weeknd", Genre = "Pop", Duration = 230, TotalPlays = 2800000 });
playlist.AjouterChanson(new Chanson { Id = 3, Title = "HUMBLE.", Artist = "Kendrick Lamar", Genre = "Rap", Duration = 177, TotalPlays = 3100000 });
playlist.AjouterChanson(new Chanson { Id = 4, Title = "DNA.", Artist = "Kendrick Lamar", Genre = "Rap", Duration = 185, TotalPlays = 2200000 });
playlist.AjouterChanson(new Chanson { Id = 5, Title = "Bad Guy", Artist = "Billie Eilish", Genre = "Pop", Duration = 194, TotalPlays = 4100000 });
playlist.AjouterChanson(new Chanson { Id = 6, Title = "Happier Than Ever", Artist = "Billie Eilish", Genre = "Pop", Duration = 295, TotalPlays = 1900000 });
playlist.AjouterChanson(new Chanson { Id = 7, Title = "Bohemian Rhapsody", Artist = "Queen", Genre = "Rock", Duration = 354, TotalPlays = 5000000 });
playlist.AjouterChanson(new Chanson { Id = 8, Title = "Don't Stop Me Now", Artist = "Queen", Genre = "Rock", Duration = 209, TotalPlays = 3300000 });
playlist.AjouterChanson(new Chanson { Id = 9, Title = "Lose Yourself", Artist = "Eminem", Genre = "Rap", Duration = 326, TotalPlays = 4500000 });
playlist.AjouterChanson(new Chanson { Id = 10, Title = "Sicko Mode", Artist = "Travis Scott", Genre = "Rap", Duration = 312, TotalPlays = 2700000 });

//affiche :
// Toutes les chansons
Console.WriteLine("======1.Toutes les chansons===========");
foreach(var chanson in playlist.ObtenirToutes())
{
    Console.WriteLine($"{chanson.Title} by {chanson.Artist} with {chanson.TotalPlays} plays in total !");
}
// Les chansons d'un artiste filtré
Console.WriteLine("======2.Les chansons de Queen===========");
foreach(var chanson in playlist.FiltrerParAriste("Queen"))
{
    Console.WriteLine($"{chanson.Title}");
}

// La chanson la plus écoutée
Console.WriteLine("======4.La chanson la plus écoutée===========");
var chansonLaPlusEcoutee = playlist.ObtenirParEcoutes()
.First();
Console.WriteLine($"{chansonLaPlusEcoutee.Title}");


// La durée totale de la playlist (en minutes)
Console.WriteLine("======la durée totale de la playlist===========");
var totalDuration = playlist.ObtenirToutes().Sum(chanson => chanson.TotalPlays);
Console.WriteLine(totalDuration);
// Nombre de chansons par genre
var parGenre = playlist.ObtenirToutes()
.GroupBy(chanson =>chanson.Genre);

foreach(var groupe in parGenre)
{
    Console.WriteLine($"{groupe.Key} : {groupe.Count()}");
}