using DesignerPatterns.Enums;
using DesignerPatterns.Entities;
using DesignerPatterns.Interfaces;

namespace DesignerPatterns.Factories;

public static class UserFactory
{
    public static IUser Create(Role role)
    {
        switch (role)
        {
            case Role.Admin:
                return new Admin();
            case Role.Moderator:
                return new Moderator();
            case Role.Regular:
                return new Regular();
            default:
                throw new ArgumentException("Invalid role");
        }
    }
}