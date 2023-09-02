using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class LegendsService : IStoryService
{

    public void AddStory(Story story)
    {
        if (story is Legend legend)
        {
            if (string.IsNullOrEmpty(legend.StoryCode))
            {
                legend.StoryCode = CreateCode(legend.Name);
            }

            Storage.MythsAndLegends.Add(legend);
        }
    }

    public Story? GetStoryByCode(string code)
    {
        return Storage.MythsAndLegends.FirstOrDefault(legend => legend.StoryCode == code);
    }

    private string CreateCode(string name)
    {
        var code = $"{name.First()}{name.Last()}-{name.Length}";

        return code;
    }
}