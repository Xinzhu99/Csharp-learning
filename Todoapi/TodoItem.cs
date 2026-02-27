public class TodoItem
{
    public int Id
    {
        get ; set;
    }
    public string Titre {get; set;} = "";
    public bool EstTermine {get; set;}
    public DateTime DateCreation {get; set;}
}