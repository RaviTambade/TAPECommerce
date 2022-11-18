public class Books
{
    private string [] titles= new string [100];

    //indexer
    public string this [int index]
    {
        get{
            if (index <0 || index >=100)
            return 0;
        else
            return titles [index];
        }

        set{
            if (! index <0 || index >=100)
            return 0;
            else
            titles [index] =value;
        }
    }

    
    public static void Main ()
    { 
        Books mybooks=new Books ();
        Mybooks [3] ="Mogali in Jungle";
    }
}
