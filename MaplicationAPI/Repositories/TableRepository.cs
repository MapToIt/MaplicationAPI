using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories
{
    public class TableRepository : ITableRepository
    {
        private readonly EntityFramework.MaplicationContext _context;

        public TableRepository(MaplicationContext context)
        {
            _context = context;
        }
    }
}
