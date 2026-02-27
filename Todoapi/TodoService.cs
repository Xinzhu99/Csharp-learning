
public class TodoService : ITodoService
{
    private List<TodoItem> _todos;

    public TodoService(List<TodoItem> data)
    {
        _todos = data;
    }

    public List<TodoItem> ObtenirTous()
    {
        return _todos;
    }

    public TodoItem ObtenirParId(int id)
    {
        return _todos.FirstOrDefault(t=>t.Id == id);    
    }

    public List<TodoItem> ObtenirTermines()
    {
        return _todos.Where(t=>t.EstTermine == true).ToList();
    }

    public TodoItem Ajouter(TodoItem newTodo)
    {
        newTodo.Id = _todos.Count()+1;
        _todos.Add(newTodo);
        return newTodo;
    }

    public TodoItem Modifier(int id, TodoItem todoModifie)
    {
        var todoAModifier = _todos.FirstOrDefault(t=> t.Id==id);
        if (todoAModifier != null)
        {
            todoAModifier.Titre = todoModifie.Titre;
            todoAModifier.DateCreation = todoModifie.DateCreation;
            todoAModifier.EstTermine = todoModifie.EstTermine;

            return todoAModifier;
        }
        return null;
    }
    public bool Supprimer(int id)
    {
        var todoASupprimer = _todos.FirstOrDefault(t=>t.Id == id);
        if (todoASupprimer != null)
        {
            _todos.Remove(todoASupprimer);
            return true;
        }
        return false;
    }
}