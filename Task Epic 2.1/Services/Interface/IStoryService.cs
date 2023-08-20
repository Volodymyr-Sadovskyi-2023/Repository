using MythAndLegends.Data.Entity;

namespace MythAndLegends.Services.Interface;

public interface IStoryService
{
    void AddStory(Story story);
    Story? GetStoryByCode(string code);
}