using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using System.Collections.Generic;

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

        public Company InsertCompany(Company company)
        {
            return _companyRepository.InsertCompany(company);
        }

        public Company UpdateCompany(Company company)
        {
            if (_companyRepository.isCompany(company.UserId))
            {
                return _companyRepository.UpdateCompany(company);
            }
            else
            {
                return null;
            }
        }

        public bool isCompany(string id)
        {
            return _companyRepository.isCompany(id);
        }
    }
}
