using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Services
{
    public class CompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public List<Company> GetCompanies()
        {
            return _companyRepository.BrowseCompanies();
        }

        public Company GetCompany(string id)
        {
            return _companyRepository.GetCompany(id);
        }

        public void InsertCompany(Company company)
        {
            _companyRepository.InsertCompany(company);
        }

        public void UpdateCompany(Company company)
        {
            if (_companyRepository.isCompany(company.UserId))
                _companyRepository.UpdateCompany(company);
        }

        public bool isCompany(string id)
        {
            return _companyRepository.isCompany(id);
        }
    }
}
