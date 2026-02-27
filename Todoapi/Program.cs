using System.ComponentModel.Design;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var todos = new List<TodoItem>
{
    new TodoItem { Id=1, Titre="Apprendre le c", EstTermine=false,DateCreation=DateTime.Now},
};
ITodoService service = new TodoService(todos);
app.MapGet("/todos", () =>
{
    return service.ObtenirTous();
});

app.MapGet("/todos/{id}", (int id) =>
{
    return service.ObtenirParId(id);
});
app.MapGet("/todos/termines", () =>
{
    return service.ObtenirTermines();
});
app.MapPost("/todos", (TodoItem newTodo) =>
{
    return service.Ajouter(newTodo);
});
app.MapPut("/livres/{id}", (int id, TodoItem todoModifie) =>
{
    return service.Modifier(id, todoModifie);
});
app.MapDelete("/livres/{id}", (int id) =>
{
    return service.Supprimer(id);
});
app.Run();

