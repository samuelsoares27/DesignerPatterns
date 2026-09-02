using System;
using DesignerPatterns.Entities;
using DesignerPatterns.Enums;
using DesignerPatterns.Interfaces;
using DesignerPatterns.Services;
using DesignerPatterns.Factories;

namespace DesignPatterns;
public class Program
{
    public static void Main(string[] args)
    {
        UserService userAdmin = new UserService(UserFactory.Create(Role.Admin));        
        UserService userModerator = new UserService(UserFactory.Create(Role.Moderator));        
        UserService userRegular = new UserService(UserFactory.Create(Role.Regular));

        userAdmin.Execute();
        userModerator.Execute();
        userRegular.Execute();
    }

}