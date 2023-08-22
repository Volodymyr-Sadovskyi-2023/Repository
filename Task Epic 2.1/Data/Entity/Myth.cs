namespace MythAndLegends.Data.Entity;

public class Myth : Story
{
    public string Fact { get; set; }

    public override string Tell()
    {
        return $"Myth {StoryCode} - {Name}\n" +
               $"{Content}\n" +
               $"Fact: {Fact}\n" +
               base.Tell();
    }
}