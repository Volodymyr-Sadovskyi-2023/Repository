namespace MythAndLegends.Data.Entity;

public class Legend : Story
{
    public string Character { get; set; }

    public override string Tell()
    {
        return $"Legend { StoryCode } - { Name }\n" +
               $"Legend tells about { Character }\n" +
               $"{ Content }\n" +
               base.Tell();
    }
}
