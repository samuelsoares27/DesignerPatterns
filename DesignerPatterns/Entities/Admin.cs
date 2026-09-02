using DesignerPatterns.Interfaces;

namespace DesignerPatterns.Entities;

public class Admin : IUser
{
    public void ShowRules()
    {
        Console.WriteLine("The admin was created.");
    }
}