using DesignerPatterns.Interfaces;

namespace DesignerPatterns.Services;

public class UserService(IUser user){
    private readonly IUser _user = user;

    public void Execute()
    {
        _user.ShowRules();
    } 
}