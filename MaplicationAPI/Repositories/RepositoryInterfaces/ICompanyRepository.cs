using MaplicationAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories.RepositoryInterfaces
{
    public interface ICompanyRepository
    {
        List<Company> BrowseCompanies();
        Company GetCompany(string id);
        Company InsertCompany(Company company);
        Company UpdateCompany(Company company);
        bool isCompany(string id);
    }
}
