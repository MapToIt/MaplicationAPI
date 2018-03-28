using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace MaplicationAPI.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly MaplicationContext _context;

        public CompanyRepository(MaplicationContext context)
        {
            _context = context;
        }

        public List<Company> BrowseCompanies()
        {
            return _context.Company.AsNoTracking().ToList();
        }

        public Company GetCompany(string id)
        {
            return (from c in _context.Set<Company>()
                    where c.UserId == id
                    select c).SingleOrDefault();
        }

        public void InsertCompany(Company company)
        {
            _context.Company.Add(company);
            _context.SaveChanges();
        }

        public void UpdateCompany(Company company)
        {
            if (company != null)
            {
                var existingCompany = _context.Company.Where(c => c.UserId == company.UserId).FirstOrDefault();

                if (existingCompany != null)
                {
                    existingCompany.ZipCode = company.ZipCode;
                    existingCompany.UserId = company.UserId;
                    existingCompany.Url = company.Url;
                    existingCompany.StreetNumber = company.StreetNumber;
                    existingCompany.Street = company.Street;
                    existingCompany.StateId = company.StateId;
                    existingCompany.State = company.State;
                    existingCompany.PhoneNumber = company.PhoneNumber;
                    existingCompany.Logo = company.Logo;
                    existingCompany.CompanyName = company.CompanyName;
                    existingCompany.City = company.City;
                    existingCompany.Chips = company.Chips;

                    _context.SaveChanges();
                }
                else
                {
                    return;
                }
            }
            return;
        }
    

        public bool isCompany(string id)
        {
            return _context.Company.Any(a => a.UserId == id);
        }
    }
}
