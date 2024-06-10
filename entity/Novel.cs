public class Novel : Book
{
    private string writter;
    public Novel(string title, int publicationYear, string publisher, string code, string writter) : base(title, publicationYear, publisher, code)
    {
        this.writter = writter;
    }
    public override string GetTitle()
    {
        return base.Title;
    }
    public string Writter
    {
        get { return writter; }
        set { writter = value; }
    }


}