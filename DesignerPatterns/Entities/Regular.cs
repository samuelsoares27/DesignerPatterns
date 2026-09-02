using DesignerPatterns.Interfaces;

namespace DesignerPatterns.Entities;

public class Regular : IUser
{
    public void ShowRules()
    {
        Console.WriteLine("The regular was created.");
    }
}