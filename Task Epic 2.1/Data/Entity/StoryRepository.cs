namespace MythAndLegends.Data.Entity;

public class StoryRepository
{
    private List<Story> _stories = new List<Story>();

    public void AddStory(Story story)
    {
        _stories.Add(story);
    }

    public Story? GetStoryByCode(string code)
    {
        return _stories.FirstOrDefault(story => story.StoryCode == code);
    }
}