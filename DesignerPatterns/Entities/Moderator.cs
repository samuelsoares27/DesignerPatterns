using DesignerPatterns.Interfaces;

namespace DesignerPatterns.Entities;

public class Moderator : IUser
{
    public void ShowRules()
    {
        Console.WriteLine("The moderator was created.");
    }
}