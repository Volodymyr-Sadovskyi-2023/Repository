using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class Display : IDisplay
{
    private readonly IStoryService _storyService;

    public Display(IStoryService storyService)
    {
        _storyService = storyService;
    }

    public void DisplayByCode(string code)
    {
        var story = _storyService.GetStoryByCode(code);

        if (story is not null)
        {
            story.Tell();
        }
        else
        {
            Console.WriteLine($"No story with code {code}");
        }
    }

    public void AddNewStory(Story story)
    {
        _storyService.AddStory(story);
    }
}
