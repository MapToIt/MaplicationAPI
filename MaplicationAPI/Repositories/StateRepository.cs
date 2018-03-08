using MaplicationAPI.EntityFramework;
using MaplicationAPI.Repositories.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaplicationAPI.Repositories
{
    public class StateRepository : IStateRepository
    {
        private readonly EntityFramework.MaplicationContext _context;

        public StateRepository(MaplicationContext context)
        {
            _context = context;
        }


        public List<State> BrowseStates()
        {
            return _context.State.AsNoTracking().ToList();
        }
    }
}
