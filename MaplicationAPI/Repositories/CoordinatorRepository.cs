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

        public void AddCoord(Coordinator _Coordinator)
        {
            _context.Coordinator.Add(_Coordinator);
            _context.SaveChanges();
        }

        public void UpdateCoord(Coordinator _Coordinator)
        {
            var existingCoord = _context.Coordinator.Update(_Coordinator);

            if (existingCoord != null)
            {

                _context.SaveChanges();
            }
            else
            {
                return;
            }
            return;
        }

        public void CoordEvent(Coordinator _coordinator)
        {
            throw new NotImplementedException();
        }
    }
}
