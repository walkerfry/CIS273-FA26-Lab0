namespace Prayer;


public class Prayer : AuditableRecord
{
    public string Title { get; set; } = "";

    public string? Subtitle { get; set; }

    public string Body { get; set; } = "";

    public List<ScriptureReference> ScriptureReferences { get; set; } = new();

    public Author? Author { get; set; }

    public List<Tag> Tags { get; set; } = new();

    public Uri? ImageUrl { get; set; }

    public override string ToString()
    {
        List<string> lines = new() { Title};

        if (Subtitle != null)
        {
            lines.Add(Subtitle);
        }

        if (Author != null)
        {
            lines.Add($"by {Author}");
        }

        if (ScriptureReferences.Count > 0)
        {
            lines.Add(string.Join(", ", ScriptureReferences));
        }

        if (Tags.Count > 0)
        {
            lines.Add($"Tags: {string.Join(", ", Tags.Select(tag => tag.Name))}");
        }

        //convert sr objects to strings
        //List<string> scriptureReferencesStrings = new();

        //result += string.Join(",", ScriptureReferences);
        //result += "\n";
        
        
        //for(int i=0; i < ScriptureReferences?.Count; i++)
        //{
        //    result += ScriptureReferences[i];
        //    if(i!= ScriptureReferences.Count - 1)
        //    {
        //        result += ", ";
        //    }
        //}
        
        


        return string.Join(Environment.NewLine, lines);
    }
}
