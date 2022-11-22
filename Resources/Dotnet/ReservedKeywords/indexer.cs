public class Books
{
    private string [] titles= new string [100];
    //indexer
    public string this [int index]
    {
        get{
            if (index <0 || index >=100)
             throw new Exception("index is not in context");
        else
            return titles [index];
        }

        set{
            if (index <0 || index >=100)
                throw new Exception("index is not in context");
            else
            titles [index] =value;
        }
    }

    
    public static void Main ()
    { 
        Books mybooks=new Books ();
        mybooks [3] ="Mogali in Jungle";
    }
}
