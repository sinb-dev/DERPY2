using System;
using System.Data.SQLite;
using DERPY.Model;
using TECHCOOL.UI;

namespace DERPY
{
    public class CompanyListPage : Screen
    {
        public override string Title {get;set;} = "Selskaber";

        protected override void Draw()
        {
            Console.CursorVisible = false;
            ListPage<Company> listPage = new();
            listPage.AddColumn("Selskab", nameof(Company.CompanyName), 40);
            listPage.AddColumn("Land", nameof(Company.Country));
            listPage.AddColumn("Valuta", nameof(Company.Currency), 5);

            listPage.Add( new Company {CompanyName = "Foderbrættet A/S", Country = "Danmark", Currency = Currency.DKK });
            listPage.Add( new Company {CompanyName = "Foodboard Ltd", Country = "USA", Currency = Currency.USD });

            listPage.Select();
        }
    }
}

