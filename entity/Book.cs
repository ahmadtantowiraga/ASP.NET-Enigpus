public abstract class Book
{
    private string title;
    private int publicationYear;
    private string code;
    private string publisher;

    public Book(string title, int publicationYear, string publisher, string code)
    {
        this.title = title;
        this.publicationYear = publicationYear;
        this.publisher = publisher;
        this.code = code;
    }
    public abstract string GetTitle();
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public int PublicationYear
    {
        get { return publicationYear; }
        set { publicationYear = value; }
    }

    public string Code
    {
        get { return code; }
        set { code = value; }
    }

    public string Publisher
    {
        get { return publisher; }
        set { publisher = value; }
    }
}