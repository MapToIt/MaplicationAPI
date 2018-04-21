using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories
{
    public class SalaryTypeRepository : ISalaryTypeRepository
    {
        private readonly EntityFramework.MaplicationContext _context;

        public SalaryTypeRepository(MaplicationContext context)
        {
            _context = context;
        }


        public List<SalaryTypes> BrowseSalaryTypes()
        {
            return _context.SalaryTypes.AsNoTracking().ToList();
        }
    }
}
