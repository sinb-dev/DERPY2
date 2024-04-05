using System;
using System.Data.SQLite;
using DERPY.Model;
using TECHCOOL.UI;

namespace DERPY
{
    public class CompanyDetails : Screen
    {
        public override string Title {get;set;} = "Selskab";
        Company company = new();

        public CompanyDetails(Company company)
        {
            Title = "Detaljer for " + company.CompanyName;
            this.company = company;
        }

        protected override void Draw()
        {
            
            Console.WriteLine(company.CompanyName);
            Console.WriteLine("Adresse:");
            Console.WriteLine("{0} {1}", company.Street, company.Number);
            Console.WriteLine("{0} {1}", company.City, company.Country);
            Console.WriteLine("Valuta: {0}", company.Currency);

            Console.WriteLine("Tryk F2 for at redigere");
            AddKey(ConsoleKey.F2, () => {
                Screen.Display( new CompanyEditor(company) );
            });
            ExitOnEscape();
        }
    }
}

