using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories
{
    public class RatingTypeRepository : IRatingTypeRepository
    {
        private readonly EntityFramework.MaplicationContext _context;

        public RatingTypeRepository(MaplicationContext context)
        {
            _context = context;
        }

        public List<RatingType> BrowseRatingType()
        {
            return _context.RatingType.AsNoTracking().ToList();
        }
    }
}
