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

        public bool isCompany(string id)
        {
            return _context.Company.Any(a => a.UserId == id);
        }
    }
}
