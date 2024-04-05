using System;
using DERPY.Model;
using TECHCOOL.UI;
using DERPY.Data;

namespace DERPY
{
    public class CompanyEditor : Screen
    {
        public override string Title {get;set;} = "Selskab";
        Company company = new();

        public CompanyEditor(Company company)
        {
            Title = "Redigerer for " + company.CompanyName;
            this.company = company;
        }

        protected override void Draw()
        {
            ExitOnEscape();
            Form<Company> form = new();

            form.TextBox("Name", nameof(Company.CompanyName));
            form.SelectBox("Currency", nameof(Company.Currency));
            form.AddOption("Currency", "DKK", Currency.DKK);
            form.AddOption("Currency", "EUR", Currency.EUR);
            form.AddOption("Currency", "USD", Currency.USD);
            form.AddOption("Currency", "SEK", Currency.SEK);
            if (form.Edit(company)) 
            {
                Database.Instance.UpdateCompany(company);
                Console.WriteLine("Ændringerne blev gemt");
            }
            else
            {
                Console.WriteLine("Ingen ændringer");
            }
            
            
        }
    }
}

