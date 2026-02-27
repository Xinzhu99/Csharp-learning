public interface ITodoService
{
    List<TodoItem> ObtenirTous();
    TodoItem ObtenirParId(int id);
    List<TodoItem> ObtenirTermines();
    TodoItem Ajouter(TodoItem newTodo);
    TodoItem Modifier(int id, TodoItem todoModifie);
    bool Supprimer(int id);
}