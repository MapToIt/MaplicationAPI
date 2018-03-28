using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories
{
    public class ChipsRepository : IChipsRepository
    {
        private readonly EntityFramework.MaplicationContext _context;

        public ChipsRepository(MaplicationContext context)
        {
            _context = context;
        }

        public List<Tags> BrowseChips()
        {
            return _context.Tags.AsNoTracking().ToList();
        }
    }
}
