using System;
using DERPY;
using TECHCOOL.UI;
namespace DERPY;
public class MainMenu : Screen
{
        public override string Title {get;set;} = "DERPY SOFTWARE";
        protected override void Draw() 
        {
            //Print som text
            Console.WriteLine("Welcome to DERPY SOFTWARE");
            Console.WriteLine("Please select a module to proceed");

            //
            Menu menu = new();
            menu.Add(new CompanyListPage());
            menu.Start(this);
        }
}