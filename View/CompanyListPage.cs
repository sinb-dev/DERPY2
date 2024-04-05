using System;
using DERPY.Data;
using DERPY.Model;
using TECHCOOL.UI;

namespace DERPY
{
    public class CompanyListPage : Screen
    {
        //Set the title of this page
        public override string Title {get;set;} = "Selskaber";

        protected override void Draw()
        {
            Console.CursorVisible = false;

            //A ListPage draws columns and rows in a box
            ListPage<Company> listPage = new();

            //Add some columns
            listPage.AddColumn("Selskab", nameof(Company.CompanyName), 40);
            listPage.AddColumn("Land", nameof(Company.Country));
            listPage.AddColumn("Valuta", nameof(Company.Currency), 8);

            //Get companies from the database and add them to the list
            var companies = Database.Instance.GetCompanies();
            foreach (Company model in companies) 
            {
                listPage.Add(model);
            }

            //Enable selection of a company by using arrow keys
            var company = listPage.Select();
            if (company != null) 
            {
                //Ask Screen class to display the CompanyDetails view
                Screen.Display(new CompanyDetails(company));
            }
        }
    }
}

