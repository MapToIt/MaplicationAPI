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
    public class CoordinatorRepository : ICoordinatorRepository
    {
        private readonly MaplicationContext _context;

        public CoordinatorRepository(MaplicationContext context)
        {
            _context = context;
        }

        public bool isCoordinator(string id)
        {
            return _context.Coordinator.Any(a => a.UserId == id);
        }
    }
}
