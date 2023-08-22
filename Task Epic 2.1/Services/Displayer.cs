using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class Display : IDisplay
{
    private readonly IStoryService _storyService;
    private readonly StoryDisplayer _storyDisplayer;

    public Display(IStoryService storyService, StoryDisplayer storyDisplayer)
    {
        _storyService = storyService;
        _storyDisplayer = storyDisplayer;
    }

    public void DisplayByCode(string code)
    {
        var story = _storyService.GetStoryByCode(code);
        _storyDisplayer.DisplayStory(story);
    }
}
