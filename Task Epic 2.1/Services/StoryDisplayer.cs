using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class StoryDisplayer
{
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
