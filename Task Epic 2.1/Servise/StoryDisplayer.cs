using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class StoryDisplayer : IStoryService
{
    public void AddStory(Story story)
    {
        Storage.MythsAndLegends.Add(story);
    }

    public Story? GetStoryByCode(string code)
    {
        return Storage.MythsAndLegends.FirstOrDefault(x => x.StoryCode == code);
    }

    public void DisplayStory(Story story)
    {
        if (story != null)
        {
            Console.WriteLine(story.Tell());
        }
        else
        {
            Console.WriteLine("No story to display");
        }
    }
}
