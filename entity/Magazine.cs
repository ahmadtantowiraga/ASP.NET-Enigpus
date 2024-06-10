public class Magazine : Book
{
    public Magazine(string title, int publicationYear, string publisher, string code) : base(title, publicationYear, publisher, code)
    {
    }
    public override string GetTitle()
    {
        return base.Title;
    }

}