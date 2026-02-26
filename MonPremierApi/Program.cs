
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// Fausse base de données pour l'instant
var livres = new List<Livre>
{
    new Livre { Id = 1, Titre = "Dune", Auteur = "Frank Herbert", Genre = "SF", Annee = 1965, Note = 9.1 },
    new Livre { Id = 2, Titre = "1984", Auteur = "George Orwell", Genre = "Dystopie", Annee = 1949, Note = 9.3 },
    new Livre { Id = 3, Titre = "Fondation", Auteur = "Isaac Asimov", Genre = "SF", Annee = 1951, Note = 8.7 }
};
ILivreService service = new LivreService(livres);

// Notre premier endpoint
app.MapGet("/livres", () =>
{
    return service.ObtenirTous(); 
});

app.MapGet("/livres/{id}", (int id) =>
{
    return service.ObtenirParId(id);
});

app.MapPost("/livres", (Livre nouveauLivre) =>
{
   nouveauLivre.Id = livres.Count + 1;
   return service.Ajouter(nouveauLivre);
});


app.MapPut("/livres/{id}", (int id, Livre livreModifie) =>
{
    return service.Modifier(id, livreModifie);
});


app.MapDelete("/livres/{id}", (int id) =>
{
    return service.Supprimer(id);
});
app.Run();
