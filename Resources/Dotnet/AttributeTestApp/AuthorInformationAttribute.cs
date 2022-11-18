namespace  Metadata;

public class AuthorInformationAttribute : Attribute
{
    public int YearPublished { get; set; }
    public string AuthorName { get; set; }
    
    public AuthorInformationAttribute(int year)
    {
        YearPublished = year;
    }

    public AuthorInformationAttribute(string name, int year)
    {
        AuthorName = name;
        YearPublished = year;
    }
}