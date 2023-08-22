namespace MythAndLegends.Data.Entity;

public class Legend : Story
{
    public string Object { get; set; }

    public override string Tell()
    {
        return $"Legend {StoryCode} - {Name}\n" +
               $"Legend tells about {Object}\n" +
               $"{Content}\n" +
               base.Tell();
    }
}
