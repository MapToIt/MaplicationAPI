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
        void InsertCompany(Company company);
        void UpdateCompany(Company company);
        bool isCompany(string id);
    }
}
