public class Transaction
{
    public int Id {get ; set;}
    public string Description 
    {
        get ; set ;
    } = "";
    public double Montant {get ; set ;}
    public string Type
    {
        get ; set ;
    } = "";
    public string Categorie {get ; set ;} ="";
    public DateTime Date {get ; set ;}
}