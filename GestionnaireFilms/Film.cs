public class Film
{
    public int Id {get; set; }
    // get set : on peut lire et écrire cette valeur 
    public string Titre {get ; set ;} = ""; //"" => initialisé à vide, valeur par défaut 
    public string Genre {get ; set ;} 
    public int Annee {get ; set ;}
    public double Note { get ; set ;}

}