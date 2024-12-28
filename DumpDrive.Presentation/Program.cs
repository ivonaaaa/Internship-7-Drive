using System;
using System.Collections.Generic;
using DumpDrive.Presentation.Abstractions;
using DumpDrive.Presentation.Actions;
using DumpDrive.Presentation.Factories;

namespace DumpDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuFactory = new LoginAndRegistrationFactory();
            var mainMenu = menuFactory.CreateLoginAndRegisterMenu();
            mainMenu.Execute();
        }
    }
}
