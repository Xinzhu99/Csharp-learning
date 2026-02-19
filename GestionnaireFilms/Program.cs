using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.IO.Enumeration;
using System.Net.WebSockets;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

// On crée notre catalogue
ICatalog catalog = new Catalog();

// On ajoute des films de test
catalog.AjouterFilm(new Film { Id = 1, Titre = "Inception", Genre = "SF", Annee = 2010, Note = 9.2 });
catalog.AjouterFilm(new Film { Id = 2, Titre = "Titanic", Genre = "Drame", Annee = 1997, Note = 7.8 });
catalog.AjouterFilm(new Film { Id = 3, Titre = "Interstellar", Genre = "SF", Annee = 2014, Note = 8.6 });
catalog.AjouterFilm(new Film { Id = 4, Titre = "ParAjouterFilmasite", Genre = "Drame", Annee = 2019, Note = 8.5 });
catalog.AjouterFilm(new Film { Id = 5, Titre = "Dune", Genre = "SF", Annee = 2021, Note = 8.0 });

// On affiche tous les films
Console.WriteLine("=== Tous les films ===");
foreach (var film in catalog.ObtenirTous())
{
    Console.WriteLine($"{film.Titre} ({film.Annee}) - Note: {film.Note}");
}

Console.WriteLine("== on affiche les films SF==");
foreach (var film in catalog.FiltrerParGenre("SF"))
{
    Console.WriteLine($"{film.Titre} ({film.Annee}) - Note : {film.Note}");
}
Console.WriteLine("Film par note");
foreach (var film in catalog.RangerParNote())
{
    Console.WriteLine($"{film.Titre} - {film.Note}");
}


Console.WriteLine("\n===Titres des film SF triés par note===");
var titreSF = catalog.ObtenirTous()
.Where(film => film.Genre == "SF")
.OrderByDescending(film => film.Note)
.Select(film => film.Titre)
.ToList();

foreach (var titre in titreSF)
{
    Console.WriteLine(titre);
}

//créer des stats
Console.WriteLine("\nSTATS DU CATALOGUE");
//le film le mieux noté
var meilleurFilm = catalog.ObtenirTous()
.OrderByDescending(film => film.Note)
.First();
Console.WriteLine($"Meilleur film : {meilleurFilm.Titre} ({meilleurFilm.Note}/10)");

//la moyenne
var moyenne = catalog.ObtenirTous().Average(film => film.Note);
 Console.WriteLine($"La moyenne: {moyenne:F1}/10");

 //nombre de films par genre
 var parGenre = catalog.ObtenirTous()
 .GroupBy(film => film.Genre);

 foreach (var groupe in parGenre)
 {
    Console.WriteLine($"{groupe.Key} : {groupe.Count()} films");
 } 
