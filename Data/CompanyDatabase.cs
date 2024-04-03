using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DERPY.Model;

namespace DERPY.Data
{
    public partial class Database
    {
        List<Company> companies = new();
        public Company GetCompanyById(int id) 
        {
            foreach (var company in companies)
            {
                if (company.CompanyId == id) {
                    return company;
                }
            }
            return null;
        }
        
        public List<Company> GetCompanies() 
        {
            List<Company> companyCopy = new();
            companyCopy.AddRange(companyCopy);
            return companyCopy;
        }

        public void InsertCompany(Company company)
        {
            if (company.CompanyId != 0)
            {
                return;
            }
            company.CompanyId = companies.Count;
            companies.Add(company);
        }

        public void UpdateCompany(Company company)
        {
            if (company.CompanyId == 0)
            {
                return;
            }

            for (var i = 0; i < companies.Count; i++)
            {
                if (companies[i].CompanyId == company.CompanyId)
                {
                    companies[i] = company;
                }
            }
        }

        public void DeleteCompany(Company company)
        {
            if (company.CompanyId == 0)
            {
                return;
            }
            if (companies.Contains(company)) {
                companies.Remove(company);
            }
        }
    }
}
