using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class MythsService : IStoryService
{

    public void AddStory(Story story)
    {
        if (story is Myth myth)
        {
            if (string.IsNullOrEmpty(myth.StoryCode))
            {
                myth.StoryCode = CreateCode(myth.Name);
            }

            Storage.MythsAndLegends.Add(myth);
        }
    }

    public Story? GetStoryByCode(string code)
    {
        return Storage.MythsAndLegends.FirstOrDefault(myth => myth.StoryCode == code);
    }

    private string CreateCode(string name)
    {
        var code = $"{name.First()}{name.Last()}-{name.Length}";

        return code;
    }
}
