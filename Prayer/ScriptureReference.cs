namespace Prayer;

//public class Book
//{
//    public string Name { get; set; } = "";

    //date, author, metadata
 //   public override string ToString()
 //   {
 //       return Name;
 //   }
//}

public class ScriptureReference
{
    public string Book { get; set; } = "";

    public int Chapter { get; set; }

    public int StartVerse { get; set; }

    public int EndVerse { get; set; }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
}
